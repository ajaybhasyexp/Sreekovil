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

namespace View
{
    public partial class SREEKOVIL : Form
    {
        #region Load And Constructor

        public SREEKOVIL()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DeityViewModel dietyViewModel = new DeityViewModel();
            dietyViewModel.GetAllDeities();
        }

        #endregion

        #region Events

        private void btn_Offering_Click(object sender, EventArgs e)
        {
            CheckAndOpen("OfferingTransaction");
        }

        private void btn_MasterData_Click(object sender, EventArgs e)
        {
            MasterData masterData = new MasterData();
            masterData.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CheckAndOpen("Deity");
        }

        private void lbl_Offering_Click(object sender, EventArgs e)
        {
            CheckAndOpen("Offering");
        }

        private void lbl_Income_Click(object sender, EventArgs e)
        {
            CheckAndOpen("IncomeHead");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CheckAndOpen("ExpenseHead");
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
        }

        private void btn_Expense_Click(object sender, EventArgs e)
        {
            CheckAndOpen("ExpenseTransaction");
        }

        #endregion

        #region Private Methods

        private void CheckAndOpen(string formName)
        {
            var oftrans = Application.OpenForms[formName];
            if (oftrans != null)
            {
                oftrans.WindowState = FormWindowState.Normal;
                oftrans.Focus();
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                var myForm = Activator.CreateInstance(Type.GetType("View." + formName)) as Form;
                myForm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        #endregion

        
    }
}
