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
using View.ViewModels;
using ViewModel;
using ViewModel.DTOs;

namespace View
{
    public partial class OfferingTransaction : Form
    {

        #region Private Members

        private List<OfferingTransactionVM> _transactions { get; set; }


        private OfferingTransactionViewModel viewModelService { get; set; }

        #endregion

        #region Private Methods

        private void RefreshGrid()
        {
            dg_Offerings.DataSource = null;
            dg_Offerings.DataSource = _transactions;
            lbl_TotalSum.Text = _transactions.Sum(p => p.Price).ToString();
        }

        private List<OfferingTransactionDto> GetDto()
        {
            List<OfferingTransactionDto> dtos = new List<OfferingTransactionDto>();
            if (_transactions.Count > 0)
            {
                foreach (var vm in _transactions)
                {
                    var dto = new OfferingTransactionDto()
                    {
                        Date = DateTime.Now,
                        Name = vm.Name,
                        OfferingId = vm.OfferingId,
                        StarSignId = vm.StarSignId
                    };
                    dtos.Add(dto);
                }
            }
            return dtos;
        }

        private int GetCounter()
        {
            if (_transactions.Count > 0)
            {
                return _transactions.Max(p => p.Index) + 1;
            }
            return 1;
        }

        /// <summary>
        /// Empties the Text box text and refreshes the grid.
        /// </summary>
        private void ClearControls()
        {
            _transactions = new List<OfferingTransactionVM>();
            RefreshGrid();
            txt_Name.Text = string.Empty;
            txt_OfferingCode.Text = string.Empty;
            txt_StarSign.Text = string.Empty;
        }

        #endregion

        #region Constructor and Load

        public OfferingTransaction()
        {
            InitializeComponent();
            viewModelService = new OfferingTransactionViewModel();
        }

        private void OfferingTransaction_Load(object sender, EventArgs e)
        {
            _transactions = new List<OfferingTransactionVM>();
            Common.FillOfferings(cmb_Offering);
            Common.FillStarSign(cmb_Star);
            dg_Offerings.AutoGenerateColumns = false;
        }

        #endregion

        #region Events

        private void txt_OfferingCode_Leave(object sender, EventArgs e)
        {
            if (Common.ValidateIntOnly((TextBox)sender))
            {
                int code = Convert.ToInt32(txt_OfferingCode.Text);
                OfferingViewModel viewModel = new OfferingViewModel();
                var offering = viewModel.GetByCode(code);
                if (offering != null)
                    cmb_Offering.SelectedValue = offering.OfferingId;
                else
                {
                    MessageBox.Show("കോഡ് തെറ്റാണ് ");
                    txt_OfferingCode.Text = string.Empty;
                    txt_OfferingCode.Focus();
                }
            }
        }

        private void txt_StarSign_Leave(object sender, EventArgs e)
        {
            if (Common.ValidateIntOnly((TextBox)sender))
            {
                int code = Convert.ToInt32(txt_StarSign.Text);
                StarSignViewModel viewModel = new StarSignViewModel();
                var starSign = viewModel.GetByCode(code);
                if (starSign != null)
                    cmb_Star.SelectedValue = starSign.StarSignId;
                else
                {
                    MessageBox.Show("കോഡ് തെറ്റാണ് ");
                    txt_StarSign.Text = string.Empty;
                    txt_StarSign.Focus();

                }
            }
        }

        private void cmb_Offering_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (OfferingDto)cmb_Offering.SelectedItem;
            if (selectedItem != null)
            {
                if (txt_OfferingCode.Text != selectedItem.Code.ToString())
                {
                    txt_OfferingCode.Text = selectedItem.Code.ToString();
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form homePage = Application.OpenForms["SREEKOVIL"];
            homePage.WindowState = FormWindowState.Normal;
        }

        private void cmb_Star_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (StarSignDto)cmb_Star.SelectedItem;
            if (selectedItem != null)
            {
                if (txt_StarSign.Text != selectedItem.Code.ToString())
                {
                    txt_StarSign.Text = selectedItem.Code.ToString();
                }
                if (selectedItem.Code == 0)
                    txt_StarSign.Text = string.Empty;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var selectedOffering = (OfferingDto)cmb_Offering.SelectedItem;
            var selectedStar = (StarSignDto)cmb_Star.SelectedItem;

            if (selectedOffering != null)
            {
                var starSign = string.Empty;
                if (selectedStar != null && selectedStar.StarSignId != 0)
                {
                    starSign = selectedStar.StarSignName;
                }
                OfferingTransactionVM vm = new OfferingTransactionVM()
                {
                    Index = GetCounter(),
                    Name = txt_Name.Text,
                    OfferingName = cmb_Offering.Text,
                    StarSignName = starSign,
                    OfferingId = selectedOffering.OfferingId,
                    Price = selectedOffering.Price
                };
                if (!string.IsNullOrEmpty(starSign))
                {
                    vm.StarSignId = selectedStar.StarSignId;
                }
                _transactions.Add(vm);
                txt_Name.Text = string.Empty;
                RefreshGrid();
                txt_OfferingCode.Focus();
            }
            else
            {
                MessageBox.Show("ദയവായി വഴിപാട് തിരഞ്ഞെടുക്കുക ");
            }

        }

        private void dg_Offerings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                _transactions.RemoveAt(e.RowIndex);
                RefreshGrid();
            }
        }

        private void btn_PrintReceipt_Click(object sender, EventArgs e)
        {
            if (_transactions.Count > 0)
            {
                try
                {
                    viewModelService.AddOfferingTransaction(GetDto());
                    ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("എന്തോ തകരാറു നടന്നു");
                }
            }
            else
            {
                MessageBox.Show("എന്തെങ്കിലും ചേർക്കാതെ രസീതി അടിക്കാൻ കഴിയില്ല");
            }
        }

        #endregion

    }
}
