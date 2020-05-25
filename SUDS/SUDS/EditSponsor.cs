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
    public partial class EditSponsor : Form
    {
        public SudsDb db { get; set; }
        public User sp { get; set; }
        public EditSponsor()
        {
            InitializeComponent();
        }

        private void EditSponsor_Load(object sender, EventArgs e)
        {
            nameBox.Text = sp.Name;
            surnameBox.Text = sp.Surname;
            dateOfBirthBox.Value = sp.DateOfBirth;
            loginBox.Text = sp.Login;
            passwordBox.Text = sp.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.Name = nameBox.Text;
            sp.Surname = surnameBox.Text;
            sp.DateOfBirth = dateOfBirthBox.Value;
            sp.Login = loginBox.Text;
            sp.Password = passwordBox.Text;
            db.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
