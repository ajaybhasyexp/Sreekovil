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
    public partial class ExpenseTransaction : Form
    {
        public ExpenseTransaction()
        {
            InitializeComponent();
        }

        private void btnSaveExpenseTransaction_Click(object sender, EventArgs e)
        {
            var selectedItem = (ExpenseHeadDto)cmbExpenseHead.SelectedItem;
            if (string.IsNullOrEmpty(txtPriceExpenseTransaction.Text) && (DateExpenseTransaction.Value == null) && cmbExpenseHead.SelectedValue == null)
            {
                lblMsg.Text = "Please enter details.";
                return;
            }
            if (selectedItem != null)
            {
                ExpenseTransactionDto expenseTransDto = new ExpenseTransactionDto
                {
                    ExpenseHeadId = selectedItem.ExpenseHeadId,

                    Price = Convert.ToDecimal(txtPriceExpenseTransaction.Text),
                    ExpenseDescription = txtExpenseDescription.Text,
                    ExpenseTransactionDate = DateExpenseTransaction.Value
                };

                ExpenseTransactionViewModel expenseTransactionViewModel = new ExpenseTransactionViewModel();

                if (expenseTransactionViewModel.AddExpenseTransaction(expenseTransDto))
                {
                    lblMsg.Text = "Successfully Saved";
                    txtExpenseDescription.Text = string.Empty;
                    txtPriceExpenseTransaction.Text = string.Empty;

                }
                else
                {
                    // lblMsg.ForeColor =;
                    lblMsg.Text = "Unable to Save the Changes.Please fill .";
                }
            }
        }

        private void ExpenseTransaction_Load(object sender, EventArgs e)
        {
            Common.FillExpenses(cmbExpenseHead);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbExpenseHead_Enter(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
