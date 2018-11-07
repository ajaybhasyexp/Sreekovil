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
    public partial class ExpenseHead : Form
    {
        #region Load and Constructor

        public ExpenseHead()
        {
            InitializeComponent();
            lblMsg.Text = string.Empty;
            dg_ExpenseHead.AutoGenerateColumns = false;
            showGrid();
        }

        private void ExpenseHead_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Private Methods

        private void showGrid()
        {
            ExpenseHeadViewModel expenseHeadViewModel = new ExpenseHeadViewModel();
            var showExpense = expenseHeadViewModel.GetExpenseHead();
            dg_ExpenseHead.DataSource = showExpense.ToList();
        }

        #endregion

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExpense.Text))
            {
                lblMsg.Text = "ദയവായി വിവരങ്ങൾ ടൈപ്പ് ചെയ്യുക";
                return;
            }
            ExpenseHeadDto ExpenseHeadDto = new ExpenseHeadDto
            {
                ExpenseHeadName = txtExpense.Text,
                ExpenseDescription = txtDescription.Text,
            };
            ExpenseHeadViewModel expenseHeadViewModel = new ExpenseHeadViewModel();

            if (expenseHeadViewModel.InsertExpenseHead(ExpenseHeadDto))
            {
                lblMsg.Text = "ചേർത്തിരിക്കുന്നു";
                txtExpense.Text = string.Empty;
                txtDescription.Text = string.Empty;
                showGrid();
            }
            else
            {
                lblMsg.Text = "എന്തോ തകരാറു സംഭവിച്ചിരിക്കുന്നു";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_ExpenseHead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var idColumn = senderGrid.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        #endregion        
    }
}
