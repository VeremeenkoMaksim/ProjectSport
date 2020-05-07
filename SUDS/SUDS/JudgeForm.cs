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
        
        public JudgeForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            LogUpJudge form = new LogUpJudge();
            form.Show();
        }

        private void JudgeForm_Load(object sender, EventArgs e)
        {
            SudsDb db = new SudsDb();
            User[] judges = new User[db.Users.Count()];
            int i = 0;
            foreach (User u in db.Users) {
                if (u.Role == 1) {
                    judges[i] = u;
                    i++;
                }
            }
            var data = from judge in db.Users
                       select new
                       {
                           Имя = judge.Name,
                           Фамилия = judge.Surname,
                           Дата_рождения = judge.DateOfBirth
                       };

            dataGridView1.DataSource = data.ToList();
        }
    }
}
