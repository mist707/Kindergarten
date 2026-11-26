using System;
using System.Windows.Forms;

namespace Kindergarten
{
    /// <summary>
    /// Добавление и редактирование группы
    /// </summary>
    public partial class Form4 : Form
    {
        private Group _group; // null - новая группа

        public Form4(Group group)
        {
            InitializeComponent();
            _group = group;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBoxAge.Items.Add("Ясельная (1-2 года)");
            comboBoxAge.Items.Add("Первая младшая (2-3 года)");
            comboBoxAge.Items.Add("Младшая (3-4 года)");
            comboBoxAge.Items.Add("Средняя (4-5 лет)");
            comboBoxAge.Items.Add("Старшая (5-6 лет)");
            comboBoxAge.Items.Add("Подготовительная (6-7 лет)");

            comboBoxTeacher.Items.Add("не назначен");
            foreach (Teacher t in DataStorage.Teachers) comboBoxTeacher.Items.Add(t);

            if (_group == null)
            {
                this.Text = "Новая группа";
                comboBoxAge.SelectedIndex = 2;
                comboBoxTeacher.SelectedIndex = 0;
                numericUpDownMax.Value = 20;
            }
            else
            {
                this.Text = "Редактирование группы";
                textBoxName.Text = _group.Name;
                comboBoxAge.SelectedItem = _group.AgeCategory;
                numericUpDownMax.Value = _group.MaxCount;
                Teacher t = DataStorage.FindTeacher(_group.TeacherId);
                if (t == null) comboBoxTeacher.SelectedIndex = 0;
                else comboBoxTeacher.SelectedItem = t;
            }
            labelHeader.Text = this.Text; // заголовок в цветной полосе
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            if (name == "" || comboBoxAge.SelectedItem == null)
            {
                ShowWarning("Введите название и выберите возрастную категорию");
                return;
            }
            if (name.Contains(";"))
            {
                ShowWarning("Символ «;» использовать нельзя");
                return;
            }

            // Название группы должно быть уникальным
            foreach (Group g in DataStorage.Groups)
            {
                if (g != _group && g.Name.ToLower() == name.ToLower())
                {
                    ShowWarning("Группа с таким названием уже есть");
                    return;
                }
            }

            int max = (int)numericUpDownMax.Value;
            if (_group != null && DataStorage.CountChildren(_group.Id) > max)
            {
                ShowWarning("В группе уже " + DataStorage.CountChildren(_group.Id) + " детей. Количество мест не может быть меньше");
                return;
            }

            int teacherId = 0;
            if (comboBoxTeacher.SelectedItem is Teacher)
            {
                Teacher t = (Teacher)comboBoxTeacher.SelectedItem;
                Group other = DataStorage.GetGroupOfTeacher(t.Id);
                if (other != null && other != _group)
                {
                    ShowWarning("Воспитатель уже ведёт группу «" + other.Name + "»");
                    return;
                }
                teacherId = t.Id;
            }

            if (_group == null)
            {
                _group = new Group();
                _group.Id = DataStorage.NextGroupId();
                DataStorage.Groups.Add(_group);
            }
            _group.Name = name;
            _group.AgeCategory = comboBoxAge.SelectedItem.ToString();
            _group.MaxCount = max;
            _group.TeacherId = teacherId;

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ShowWarning(string text)
        {
            MessageBox.Show(text, "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
