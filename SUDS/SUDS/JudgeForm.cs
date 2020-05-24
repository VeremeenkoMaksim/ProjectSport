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
                loadData();
            };
            form.Show();

        }

        private void JudgeForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditJudge form = new EditJudge();
            form.db = db;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                User jg = (from User in db.Users where User.Id == id select User).FirstOrDefault<User>();
                form.jg = jg;
                form.ShowDialog();
                loadData();
            }
            else {
                MessageBox.Show("Выделите строку с судьей");
            }
        }
        private void loadData() {
            var data = from User in db.Users
                       where User.Role == 1
                       select new
                       {
                           Id = User.Id,
                           Имя = User.Name,
                           Фамилия = User.Surname,
                           Дата_рождения = User.DateOfBirth
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
