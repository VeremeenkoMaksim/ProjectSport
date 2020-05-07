using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUDS
{
    public partial class KindOfSportForm : Form
    {
        SudsDb db;
        public KindOfSportForm()
        {
            InitializeComponent();
        }

        private void KindOfSportForm_Load(object sender, EventArgs e)
        {
             db = new SudsDb();
           // db.KindsOfSport.Load();
            var data = from kindOfSport in db.KindsOfSport
                       select new
                       {
                           Название = kindOfSport.NameOfSport,
                           Категория = kindOfSport.Category.Name,
                       };
            dataGridView1.DataSource = data.ToList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddKindOfSport form = new AddKindOfSport();
            form.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
