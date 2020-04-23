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
    public partial class AddKindOfSport : Form
    {
        public AddKindOfSport()
        {
            InitializeComponent();
        }

        private void AddKindOfSport_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        void LoadCategories() {
            SudsDb db = new SudsDb();

        }

        private void selectCategoryButton_Click(object sender, EventArgs e)
        {
            SelectCategories form = new SelectCategories();
            form.ShowDialog();
        }
    }
}
