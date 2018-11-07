using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;
using ViewModel.DTOs;

namespace View
{
    public partial class IncomeHead : Form
    {
        public IncomeHead()
        {
            InitializeComponent();
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIncome.Text))
            {
                lblMsg.Text = "Please enter details.";
                return;
            }
            IncomeHeadDto incomeHeadDto = new IncomeHeadDto
            {
                IncomeHeadName = txtIncome.Text,
                IncomeHeadDescription = txtDescription.Text,
            };
            IncomeHeadViewModel incomeHeadViewModel = new IncomeHeadViewModel();

            if (incomeHeadViewModel.InsertIncomeHead(incomeHeadDto))
            {
                lblMsg.Text = "Successfully Saved";
                txtIncome.Text = string.Empty;
                txtDescription.Text = string.Empty;
            }
            else
            {
                // lblMsg.ForeColor =;
                lblMsg.Text = "Unable to Save the Changes.Please fill .";
            }
        }

        private void IncomeHead_Load(object sender, EventArgs e)
        {

        }
    }
}
