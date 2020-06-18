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
        public EditCompetition()
        {
            InitializeComponent();
        }

        private void EditCompetition_Load(object sender, EventArgs e)
        {

        }
    }
}
