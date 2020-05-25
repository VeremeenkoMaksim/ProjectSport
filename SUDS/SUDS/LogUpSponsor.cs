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
    public partial class LogUpSponsor : Form
    {
        public SudsDb db { get; set; }
        bool exist = false;
        public LogUpSponsor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Replace(" ", "") != "" && surnameBox.Text.Replace(" ", "") != "" && passwordBox.Text.Replace(" ", "") != "" && loginBox.Text.Replace(" ", "") != "")
            {
                User newData = new User()
                {
                    Name = nameBox.Text,
                    Surname = surnameBox.Text,
                    DateOfBirth = dateOfBirthBox.Value.Date,
                    Login = loginBox.Text,
                    Password = passwordBox.Text,
                    Role = 0
                };
                foreach (User u in db.Users)
                {
                    if (u.Name.Equals(newData.Name) && u.Surname.Equals(newData.Surname) && u.Role == 0)
                    {
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
                else
                {
                    MessageBox.Show(null, "Такой организатор уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(null, "Сначала заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogUpSponsor_Load(object sender, EventArgs e)
        {

        }
    }
}
