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
    public partial class Authorization : Form
    {
        public SudsDb db { get; set; }
        public User user { get; set; }

        public Authorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = (from use in db.Users where textBox1.Text == use.Login && textBox2.Text == use.Password select use).FirstOrDefault<User>();
            if (user != null) this.Close();
            else MessageBox.Show("Неправильный логин или пароль!");
        }
    }
}
