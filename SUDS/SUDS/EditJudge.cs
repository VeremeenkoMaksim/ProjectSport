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
    public partial class EditJudge : Form
    {
        public SudsDb db { get; set; }
        public User jg { get; set; }
        public EditJudge()
        {
            InitializeComponent();
        }

        private void EditJudge_Load(object sender, EventArgs e)
        {
            nameBox.Text = jg.Name;
            surnameBox.Text = jg.Surname;
            dateOfBirthBox.Value = jg.DateOfBirth;
            loginBox.Text = jg.Login;
            passwordBox.Text = jg.Password;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            jg.Name = nameBox.Text;
            jg.Surname = surnameBox.Text;
            jg.DateOfBirth = dateOfBirthBox.Value;
            jg.Login = loginBox.Text;
            jg.Password = passwordBox.Text;
            db.SaveChanges();
            this.Close();
        }
    }
}
