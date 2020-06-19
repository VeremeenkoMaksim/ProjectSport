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
    public partial class EditCompetition : Form
    {
        public SudsDb db { get; set; }
        public KindOfSport ks { get; set; }
        public Competition competition { get; set; }
        public EditCompetition()
        {
            InitializeComponent();
        }

        private void EditCompetition_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = competition.Date;
            foreach (KindOfSport kos in db.KindsOfSport)
            {
                KoS.Items.Add(kos.NameOfSport);
            }
            KoS.SelectedItem = competition.KindOfSport.NameOfSport;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            competition.KindOfSport.NameOfSport = KoS.SelectedItem.ToString();
            competition.Date = dateTimePicker1.Value;
            db.SaveChanges();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
