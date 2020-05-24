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
    public partial class EditKindOfSport : Form
    {
        public KindOfSport ks { get; set; }
        public SudsDb db { get; set; }
        public Category cat { get; set; }
        public EditKindOfSport()
        {
            InitializeComponent();
        }

        private void EditKindOfSport_Load(object sender, EventArgs e)
        {
            NameBox.Text = ks.NameOfSport;
            ks.Category = cat;
            CategoryLabel.Text = ks.Category.Name;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            ks.NameOfSport = NameBox.Text;
            ks.Category = cat;
            db.SaveChanges();
            this.Close();
        }

        private void selectCategoryButton_Click(object sender, EventArgs e)
        {
            SelectCategories form = new SelectCategories();
            form.db = db;
            form.ShowDialog();
            cat = form.cat;
            CategoryLabel.Text = cat.Name;
        }
    }
}
