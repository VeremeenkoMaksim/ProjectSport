using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUDS
{
    public partial class LogUpJudge : Form
    {
        public LogUpJudge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exist = false;
            SudsDb db = new SudsDb();
            if (nameBox.Text.Replace(" ", "") != "" && surnameBox.Text.Replace(" ", "") != "" && passwordBox.Text.Replace(" ", "") != "" && loginBox.Text.Replace(" ", "") != "")
            {
                User newData = new User()
                {
                    Name = nameBox.Text,
                    Surname = surnameBox.Text,
                    Login = loginBox.Text,
                    Password = passwordBox.Text,
                    DateOfBirth = dateOfBirthBox.Value,
                    Role = 1
                };

                foreach (User u in db.Users) {
                    if (u == newData) {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    db.Users.Add(newData);
                    db.SaveChanges();
                    this.Close();
                }
                else {
                    MessageBox.Show(null, "Такой судья уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show(null, "Сначала заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
