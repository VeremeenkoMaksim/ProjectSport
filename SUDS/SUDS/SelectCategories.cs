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
    public partial class SelectCategories : Form
    {
        public SudsDb db { get; set; }
        public Category cat { get; set; }
        public string str;
        public SelectCategories()
        {
            InitializeComponent();
        }

        private void SelectCategories_Load(object sender, EventArgs e)
        {
            db.Categories.Load();
            foreach (Category cat in db.Categories) {
                comboBox1.Items.Add(cat.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = comboBox1.SelectedItem.ToString();
            cat = (from Category in db.Categories where Category.Name == str select Category).FirstOrDefault<Category>();
            this.Close();
        }
    }
}
