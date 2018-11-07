using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;
using ViewModel.DTOs;

namespace View.Helper
{
    public class Common
    {
        public static void ValidateDecimalOnly(TextBox textBox)
        {
            decimal number;
            if (textBox.Text != string.Empty && !decimal.TryParse(textBox.Text, out number))
            {
                MessageBox.Show("ദയവായി സംഖ്യകൾ മാത്രം ഉപയോഗിക്കുക!");
                textBox.Text = string.Empty;
            }
        }

        public static bool ValidateIntOnly(TextBox textBox)
        {
            int number;
            if (textBox.Text != string.Empty && !int.TryParse(textBox.Text, out number))
            {
                MessageBox.Show("ദയവായി സംഖ്യകൾ മാത്രം ഉപയോഗിക്കുക!");
                textBox.Text = string.Empty;
                return false;
            }
            else if (textBox.Text == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void FillOfferings(ComboBox cmb)
        {
            OfferingViewModel offeringViewModel = new OfferingViewModel();
            cmb.DisplayMember = "OfferingName";
            cmb.ValueMember = "OfferingId";
            cmb.DataSource = offeringViewModel.GetAllOfferings().ToList();
        }


        public static void FillStarSign(ComboBox cmb)
        {
            StarSignViewModel viewModel = new StarSignViewModel();
            cmb.DisplayMember = "StarSignName";
            cmb.ValueMember = "StarSignId";
            var entities = viewModel.GetAllStarSigns().ToList();
            StarSignDto dto = new StarSignDto()
            {
                Code = 0,
                StarSignId = 0,
                StarSignName = "തിരഞ്ഞെടുക്കുക"
            };
            entities.Add(dto);
            cmb.DataSource = entities;
            cmb.SelectedValue = 0;
        }

        public static void FillExpenses(ComboBox cmb)
        {
            ExpenseHeadViewModel expenseViewModel = new ExpenseHeadViewModel();
            cmb.DisplayMember = "ExpenseHeadName";
            cmb.ValueMember = "ExpenseHeadId";
            cmb.DataSource = expenseViewModel.GetExpenseHead().ToList();
        }
    }
}
