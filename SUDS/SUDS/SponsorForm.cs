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
    public partial class SponsorForm : Form
    {
        public SudsDb db { get; set; }
        public SponsorForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            LogUpSponsor form = new LogUpSponsor();
            form.db = db;
            form.ShowDialog();
            loadData();
        }

        private void SponsorForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData() {
            var data = from User in db.Users
                       where User.Role == 0
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

        private void Edit_Click(object sender, EventArgs e)
        {
            EditSponsor form = new EditSponsor();
            form.db = db;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                User sp = (from User in db.Users where User.Id == id select User).FirstOrDefault<User>();
                form.sp = sp;
                form.ShowDialog();
                loadData();
            }
            else
            {
                MessageBox.Show("Выделите строку с судьей");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранного организатора?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    User sp = (from User in db.Users
                               where User.Id == id
                               select User).FirstOrDefault<User>();
                    db.Users.Remove(sp);
                    db.SaveChanges();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Выделите строку с видом спорта");
            }
        }
    }
}
