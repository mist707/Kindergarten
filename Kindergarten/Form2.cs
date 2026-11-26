using System;
using System.Windows.Forms;

namespace Kindergarten
{
    /// <summary>
    /// Главная форма: дети, группы, воспитатели, отчёт
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        // Обновить все таблицы
        private void RefreshAll()
        {
            FillGroupFilter();
            ShowChildren();
            ShowGroups();
            ShowTeachers();
            ShowReport();
            labelStatus.Text = "Детей: " + DataStorage.Children.Count
                + "   Групп: " + DataStorage.Groups.Count
                + "   Воспитателей: " + DataStorage.Teachers.Count;
        }

        // ================== ДЕТИ ==================

        private void FillGroupFilter()
        {
            int selectedId = 0;
            if (comboBoxFilterGroup.SelectedItem is Group)
                selectedId = ((Group)comboBoxFilterGroup.SelectedItem).Id;

            comboBoxFilterGroup.SelectedIndexChanged -= comboBoxFilterGroup_SelectedIndexChanged;
            comboBoxFilterGroup.Items.Clear();
            comboBoxFilterGroup.Items.Add("Все группы");
            int index = 0;
            foreach (Group g in DataStorage.Groups)
            {
                comboBoxFilterGroup.Items.Add(g);
                if (g.Id == selectedId) index = comboBoxFilterGroup.Items.Count - 1;
            }
            comboBoxFilterGroup.SelectedIndex = index;
            comboBoxFilterGroup.SelectedIndexChanged += comboBoxFilterGroup_SelectedIndexChanged;
        }

        private void ShowChildren()
        {
            dataGridViewChildren.Rows.Clear();
            string search = textBoxSearch.Text.Trim().ToLower();
            int groupId = 0;
            if (comboBoxFilterGroup.SelectedItem is Group)
                groupId = ((Group)comboBoxFilterGroup.SelectedItem).Id;

            foreach (Child c in DataStorage.Children)
            {
                if (groupId != 0 && c.GroupId != groupId) continue;
                if (search != "" && !c.Fio.ToLower().Contains(search)) continue;

                dataGridViewChildren.Rows.Add(c.Id, c.Fio, c.BirthDate.ToString("dd.MM.yyyy"),
                    c.GetAge(), c.Gender, DataStorage.GetGroupName(c.GroupId), c.ParentFio, c.ParentPhone);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowChildren();
        }

        private void comboBoxFilterGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowChildren();
        }

        private void buttonAddChild_Click(object sender, EventArgs e)
        {
            if (DataStorage.Groups.Count == 0)
            {
                MessageBox.Show("Сначала создайте хотя бы одну группу", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form3 form = new Form3(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataStorage.Save();
                RefreshAll();
            }
        }

        private void buttonEditChild_Click(object sender, EventArgs e)
        {
            Child child = GetSelectedChild();
            if (child == null) return;
            Form3 form = new Form3(child);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataStorage.Save();
                RefreshAll();
            }
        }

        private void buttonDeleteChild_Click(object sender, EventArgs e)
        {
            Child child = GetSelectedChild();
            if (child == null) return;
            DialogResult res = MessageBox.Show("Удалить запись о ребёнке «" + child.Fio + "»?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                DataStorage.Children.Remove(child);
                DataStorage.Save();
                RefreshAll();
            }
        }

        private void dataGridViewChildren_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) buttonEditChild_Click(sender, e);
        }

        private Child GetSelectedChild()
        {
            if (dataGridViewChildren.CurrentRow == null)
            {
                MessageBox.Show("Выберите ребёнка в таблице", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            int id = Convert.ToInt32(dataGridViewChildren.CurrentRow.Cells[0].Value);
            return DataStorage.FindChild(id);
        }

        // ================== ГРУППЫ ==================

        private void ShowGroups()
        {
            dataGridViewGroups.Rows.Clear();
            foreach (Group g in DataStorage.Groups)
            {
                dataGridViewGroups.Rows.Add(g.Id, g.Name, g.AgeCategory,
                    DataStorage.GetTeacherName(g.TeacherId), DataStorage.CountChildren(g.Id) + " / " + g.MaxCount);
            }
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataStorage.Save();
                RefreshAll();
            }
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            Group group = GetSelectedGroup();
            if (group == null) return;
            Form4 form = new Form4(group);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataStorage.Save();
                RefreshAll();
            }
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            Group group = GetSelectedGroup();
            if (group == null) return;

            if (DataStorage.CountChildren(group.Id) > 0)
            {
                MessageBox.Show("В группе есть дети. Сначала переведите их в другую группу.", "Удаление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res = MessageBox.Show("Удалить группу «" + group.Name + "»?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                DataStorage.Groups.Remove(group);
                DataStorage.Save();
                RefreshAll();
            }
        }

        private void dataGridViewGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) buttonEditGroup_Click(sender, e);
        }

        private Group GetSelectedGroup()
        {
            if (dataGridViewGroups.CurrentRow == null)
            {
                MessageBox.Show("Выберите группу в таблице", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            int id = Convert.ToInt32(dataGridViewGroups.CurrentRow.Cells[0].Value);
            return DataStorage.FindGroup(id);
        }

        // ================== ВОСПИТАТЕЛИ ==================

        private void ShowTeachers()
        {
            dataGridViewTeachers.Rows.Clear();
            foreach (Teacher t in DataStorage.Teachers)
            {
                Group g = DataStorage.GetGroupOfTeacher(t.Id);
                dataGridViewTeachers.Rows.Add(t.Id, t.Fio, t.Phone, t.Experience, g == null ? "—" : g.Name);
            }
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataStorage.Save();
                RefreshAll();
            }
        }

        private void buttonEditTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = GetSelectedTeacher();
            if (teacher == null) return;
            Form5 form = new Form5(teacher);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataStorage.Save();
                RefreshAll();
            }
        }

        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = GetSelectedTeacher();
            if (teacher == null) return;

            Group g = DataStorage.GetGroupOfTeacher(teacher.Id);
            if (g != null)
            {
                MessageBox.Show("Воспитатель ведёт группу «" + g.Name + "». Сначала назначьте группе другого воспитателя.",
                    "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res = MessageBox.Show("Удалить воспитателя «" + teacher.Fio + "»?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                DataStorage.Teachers.Remove(teacher);
                DataStorage.Save();
                RefreshAll();
            }
        }

        private void dataGridViewTeachers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) buttonEditTeacher_Click(sender, e);
        }

        private Teacher GetSelectedTeacher()
        {
            if (dataGridViewTeachers.CurrentRow == null)
            {
                MessageBox.Show("Выберите воспитателя в таблице", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            int id = Convert.ToInt32(dataGridViewTeachers.CurrentRow.Cells[0].Value);
            return DataStorage.FindTeacher(id);
        }

        // ================== ОТЧЁТ ==================

        private void ShowReport()
        {
            dataGridViewReport.Rows.Clear();
            int totalChildren = 0;
            int totalPlaces = 0;
            foreach (Group g in DataStorage.Groups)
            {
                int count = DataStorage.CountChildren(g.Id);
                totalChildren += count;
                totalPlaces += g.MaxCount;
                int percent = g.MaxCount == 0 ? 0 : count * 100 / g.MaxCount;
                dataGridViewReport.Rows.Add(g.Name, DataStorage.GetTeacherName(g.TeacherId), count,
                    g.MaxCount, g.MaxCount - count, percent + " %");
            }
            labelReportTotal.Text = "Всего детей: " + totalChildren + " из " + totalPlaces
                + " мест. Свободно мест: " + (totalPlaces - totalChildren);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
