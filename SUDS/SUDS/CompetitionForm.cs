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
    public partial class CompetitionForm : Form
    {
        public SudsDb db { get; set; }
        public CompetitionForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddCompetition form = new AddCompetition();
            form.db = db;
            form.Add.Click += (senderS, eS) =>
            {
                loadData();
            };
            form.ShowDialog();
        }

        private void CompetitionForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            var data = from Competition in db.Competitions
                       select new
                       {
                           Id = Competition.Id,
                           Дата = Competition.Date,
                           Вид_спорта = Competition.KindOfSport.NameOfSport
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}
