using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MasterData : Form
    {
        public MasterData()
        {
            InitializeComponent();
        }

        private void btnDeity_Click(object sender, EventArgs e)
        {
            Deity deity = new Deity();
            deity.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Offering offering = new Offering();
            offering.Show();
        }
    }
}
