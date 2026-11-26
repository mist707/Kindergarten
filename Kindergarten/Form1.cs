using System;
using System.Windows.Forms;

namespace Kindergarten
{
    /// <summary>
    /// Форма входа заведующей
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DataStorage.CheckLogin(login, password))
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
