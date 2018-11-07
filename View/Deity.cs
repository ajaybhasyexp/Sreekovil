// <copyright company="AugmentiWeblabs">
//   All rights reserved. Copyright © 2016 AugmentiWeblabs.
//   This computer program may not be used, copied, distributed, corrected, modified,
//   translated, transmitted or assigned without Augmenti’s prior written authorization
// </copyright>

namespace View
{
    using System;
    using System.Windows.Forms;
    using System.Linq;
    using ViewModel;
    using ViewModel.DTOs;

    public partial class Deity : Form
    {
        #region Private Properties

        DeityViewModel deityViewModel = null;

        #endregion

        #region Private Methods

        private void RefreshGrid()
        {
            var deities = deityViewModel.GetAllDeities();
            if (deities.Any())
            {
                dg_Diety.DataSource = null;
                dg_Diety.DataSource = deities.ToList();
            }
        }

        #endregion

        #region Load and Constructor

        public Deity()
        {
            InitializeComponent();
            lblMsg.Text = null;
            deityViewModel = new DeityViewModel();
        }

        private void Deity_Load(object sender, EventArgs e)
        {
            dg_Diety.AutoGenerateColumns = false;
            RefreshGrid();            
        }

        #endregion

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeityName.Text))
            {
                lblMsg.Text = "ദയവായി പ്രതിഷ്ടയുടെ പേര് ടൈപ്പ്  ചെയ്യുക";
                return;
            }
            DeityDto deityDto = new DeityDto
            {
                DeityName = txtDeityName.Text,
                Description = txtDescription.Text,
                IsMain = chkIsMain.Checked,
            };

            if (deityViewModel.InsertDeity(deityDto))
            {
                lblMsg.Text = "ചേർത്തിരിക്കുന്നു";
                txtDeityName.Text = string.Empty;
                txtDescription.Text = string.Empty;
                chkIsMain.Checked = false;
                RefreshGrid();
            }
            else
            {
                lblMsg.Text = "എന്തോ തകരാറു സംഭവിച്ചിരിക്കുന്നു";
                txtDeityName.Focus();
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDeityName_Enter(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
        }

        #endregion       

    }
}
