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
        public EditKindOfSport(string name, string category)
        {
            InitializeComponent();
            textBox1.Text = name;
            label3.Text = category;
        }

        private void EditKindOfSport_Load(object sender, EventArgs e)
        {
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
