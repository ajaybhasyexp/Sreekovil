// <copyright company="AugmentiWeblabs">
//   All rights reserved. Copyright © 2016 AugmentiWeblabs.
//   This computer program may not be used, copied, distributed, corrected, modified,
//   translated, transmitted or assigned without Augmenti’s prior written authorization
// </copyright>

namespace View
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using View.Helper;
    using ViewModel;
    using ViewModel.DTOs;

    public partial class Offering : Form
    {
        OfferingViewModel offeringViewModel = null;

        public Offering()
        {
            InitializeComponent();
            lblMsg.Text = null;
            offeringViewModel = new OfferingViewModel();
        }

        /// <summary>
        /// The load event for this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Offering_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        /// <summary>
        /// The click event for the save button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(txtMaxPerDay.Text) || string.IsNullOrEmpty(txtOfferingName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                lblMsg.Text = "ദയവായി  മുഴുവൻ വിവരങ്ങളും എഴുതുക";
                return;
            }
            SaveOffering();
        }

        /// <summary>
        /// Saves the offering to DB.
        /// </summary>
        private void SaveOffering()
        {

            var selectedItem = (DeityDto)cmbDeity.SelectedItem;
            if (selectedItem != null)
            {
                OfferingDto offeringDto = new OfferingDto
                {
                    OfferingName = txtOfferingName.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    MaxPerDay = Convert.ToInt16(txtMaxPerDay.Text),
                    IsBookable = chk_IsBooked.Checked,
                    DeityID = selectedItem.DeityId,
                    Code = Convert.ToInt16(txtCode.Text)
                };

                if (offeringViewModel.InsertOffering(offeringDto))
                {
                    ClearControls();
                    lblMsg.Text = "വഴിപാട് ചേർത്തിരിക്കുന്നു ";
                }
            }
            else
            {
                lblMsg.Text = "ദയവായി ഒരു പ്രതിഷ്ട തിരഞ്ഞെടുക്കുകുക ";
            }
        }

        /// <summary>
        /// Clears the controls after saving the Offering.
        /// </summary>
        private void ClearControls()
        {
            txtOfferingName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtMaxPerDay.Text = string.Empty;
            chk_IsBooked.Checked = false;
            txtCode.Text = string.Empty;
        }

        /// <summary>
        /// Fills the combo box with data.
        /// </summary>
        private void FillComboBox()
        {
            try
            {
                DeityViewModel deityViewModel = new DeityViewModel();
                cmbDeity.DisplayMember = "DeityName";
                cmbDeity.ValueMember = "DeityID";
                cmbDeity.DataSource = deityViewModel.GetAllDeities().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            Common.ValidateDecimalOnly((TextBox)sender);
        }

        private void txtMaxPerDay_TextChanged(object sender, EventArgs e)
        {
            Common.ValidateIntOnly((TextBox)sender);
        }

        private void cmbDeity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOfferingName_Enter(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
        }
    }
}
