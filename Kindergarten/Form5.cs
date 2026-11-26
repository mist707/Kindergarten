using System;
using System.Windows.Forms;

namespace Kindergarten
{
    /// <summary>
    /// Добавление и редактирование воспитателя
    /// </summary>
    public partial class Form5 : Form
    {
        private Teacher _teacher; // null - новый воспитатель

        public Form5(Teacher teacher)
        {
            InitializeComponent();
            _teacher = teacher;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (_teacher == null)
            {
                this.Text = "Новый воспитатель";
            }
            else
            {
                this.Text = "Редактирование воспитателя";
                textBoxFio.Text = _teacher.Fio;
                textBoxPhone.Text = _teacher.Phone;
                numericUpDownExperience.Value = _teacher.Experience;
            }
            labelHeader.Text = this.Text; // заголовок в цветной полосе
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fio = textBoxFio.Text.Trim();
            string phone = textBoxPhone.Text.Trim();

            if (fio == "" || phone == "")
            {
                MessageBox.Show("Заполните ФИО и телефон", "Проверка данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fio.Contains(";") || phone.Contains(";"))
            {
                MessageBox.Show("Символ «;» использовать нельзя", "Проверка данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_teacher == null)
            {
                _teacher = new Teacher();
                _teacher.Id = DataStorage.NextTeacherId();
                DataStorage.Teachers.Add(_teacher);
            }
            _teacher.Fio = fio;
            _teacher.Phone = phone;
            _teacher.Experience = (int)numericUpDownExperience.Value;

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
