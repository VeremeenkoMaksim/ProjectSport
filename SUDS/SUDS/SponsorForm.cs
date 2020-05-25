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
    }
}
