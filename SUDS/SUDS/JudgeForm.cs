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
    public partial class JudgeForm : Form
    {
        public SudsDb db { get; set; }
        public JudgeForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            LogUpJudge form = new LogUpJudge();
            form.button1.Click += (senderS, eS) =>
            {
                var data = from User in db.Users
                           where User.Role == 1
                           select new
                           {
                               Имя = User.Name,
                               Фамилия = User.Surname,
                               Дата_рождения = User.DateOfBirth
                           };
                dataGridView1.DataSource = data.ToList();
            };
            form.Show();

        }

        private void JudgeForm_Load(object sender, EventArgs e)
        {
            var data = from User in db.Users
                       where User.Role == 1
                       select new
                       {
                           Имя = User.Name,
                           Фамилия = User.Surname,
                           Дата_рождения = User.DateOfBirth
                       };
            dataGridView1.DataSource = data.ToList();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
