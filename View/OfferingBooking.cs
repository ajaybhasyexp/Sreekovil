
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helper;
using ViewModel;
using ViewModel.DTOs;

namespace View
{
    public partial class OfferingBooking : Form
    {

        public OfferingBooking()
        {
            InitializeComponent();
        }

        private void OfferingBooking_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            try
            {
                Common.FillOfferings(comboBox1);
                //OfferingViewModel offeringViewModel = new OfferingViewModel();
                //comboBox1.DisplayMember = "OfferingName";
                //comboBox1.ValueMember = "OfferingId";
                //comboBox1.DataSource = offeringViewModel.GetAllOfferings().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
