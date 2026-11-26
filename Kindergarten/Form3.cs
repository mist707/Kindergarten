using System;
using System.Windows.Forms;

namespace Kindergarten
{
    /// <summary>
    /// Добавление и редактирование данных ребёнка
    /// </summary>
    public partial class Form3 : Form
    {
        private Child _child; // null - добавление нового ребёнка

        public Form3(Child child)
        {
            InitializeComponent();
            _child = child;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxGender.Items.Add("М");
            comboBoxGender.Items.Add("Ж");
            foreach (Group g in DataStorage.Groups) comboBoxGroup.Items.Add(g);

            dateTimePickerBirth.MaxDate = DateTime.Today;

            if (_child == null)
            {
                this.Text = "Новый ребёнок";
                comboBoxGender.SelectedIndex = 0;
                dateTimePickerBirth.Value = DateTime.Today.AddYears(-4);
            }
            else
            {
                this.Text = "Редактирование данных ребёнка";
                textBoxFio.Text = _child.Fio;
                dateTimePickerBirth.Value = _child.BirthDate;
                comboBoxGender.SelectedItem = _child.Gender;
                comboBoxGroup.SelectedItem = DataStorage.FindGroup(_child.GroupId);
                textBoxParentFio.Text = _child.ParentFio;
                textBoxParentPhone.Text = _child.ParentPhone;
            }
            labelHeader.Text = this.Text; // заголовок в цветной полосе
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fio = textBoxFio.Text.Trim();
            string parentFio = textBoxParentFio.Text.Trim();
            string phone = textBoxParentPhone.Text.Trim();

            // Проверка введённых данных
            if (fio == "" || parentFio == "" || phone == "")
            {
                ShowWarning("Заполните все поля");
                return;
            }
            if (fio.Contains(";") || parentFio.Contains(";") || phone.Contains(";"))
            {
                ShowWarning("Символ «;» использовать нельзя");
                return;
            }
            if (comboBoxGroup.SelectedItem == null)
            {
                ShowWarning("Выберите группу");
                return;
            }

            DateTime birth = dateTimePickerBirth.Value.Date;
            int age = DateTime.Today.Year - birth.Year;
            if (birth > DateTime.Today.AddYears(-age)) age--;
            if (age < 1 || age > 7)
            {
                ShowWarning("Возраст ребёнка должен быть от 1 до 7 лет");
                return;
            }

            Group group = (Group)comboBoxGroup.SelectedItem;
            bool groupChanged = _child == null || _child.GroupId != group.Id;
            if (groupChanged && DataStorage.CountChildren(group.Id) >= group.MaxCount)
            {
                ShowWarning("В группе «" + group.Name + "» нет свободных мест");
                return;
            }

            // Сохранение
            if (_child == null)
            {
                _child = new Child();
                _child.Id = DataStorage.NextChildId();
                DataStorage.Children.Add(_child);
            }
            _child.Fio = fio;
            _child.BirthDate = birth;
            _child.Gender = comboBoxGender.SelectedItem.ToString();
            _child.GroupId = group.Id;
            _child.ParentFio = parentFio;
            _child.ParentPhone = phone;

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
