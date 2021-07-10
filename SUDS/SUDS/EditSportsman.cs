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
    public partial class EditSportsman : Form
    {
        public SudsDb db { get; set; }
        public Sportsman s { get; set; }
        public EditSportsman()
        {
            InitializeComponent();
        }

        private void EditSportsman_Load(object sender, EventArgs e)
        {
            nameBox.Text = s.Name;
            surnameBox.Text = s.Surname;
            dateOfBirthBox.Value = s.DateOfBirth;
            WeightBox.Text = s.Weight.ToString();
            HeightBox.Text = s.Height.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Name = nameBox.Text;
            s.Surname = surnameBox.Text;
            s.DateOfBirth = dateOfBirthBox.Value;
            s.Weight = Convert.ToInt32(WeightBox.Text);
            s.Height = Convert.ToInt32(HeightBox.Text);
            db.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
