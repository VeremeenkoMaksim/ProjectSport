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
        SudsDb db;
        public JudgeForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            LogUpJudge form = new LogUpJudge();
            form.button1.Click += (senderS, eS) =>
            {
                
            };
            form.Show();

        }

        private void JudgeForm_Load(object sender, EventArgs e)
        {
            db = new SudsDb();
            //var data = from judge in db.Users
            //           select new
            //           {
            //               Имя = judge.Name,
            //               Фамилия = judge.Surname,
            //               Дата_рождения = judge.DateOfBirth
            //           };

            //dataGridView1.DataSource = data.ToList();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Имя";
            dataGridView1.Columns[1].Name = "Фамилиия";
            dataGridView1.Columns[2].Name = "Дата рождения";

            foreach (User u in db.Users)
            {
                if (u.Role == 1)
                {
                    string[] str = { u.Name, u.Surname, u.DateOfBirth.ToString() };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
