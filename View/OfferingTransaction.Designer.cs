namespace View
{
    partial class OfferingTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_OfferingCode = new System.Windows.Forms.TextBox();
            this.txt_StarSign = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.cmb_Offering = new System.Windows.Forms.ComboBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.cmb_Star = new System.Windows.Forms.ComboBox();
            this.lbl_Offering = new System.Windows.Forms.Label();
            this.lbl_Star = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dg_Offerings = new System.Windows.Forms.DataGridView();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_TotalSum = new System.Windows.Forms.Label();
            this.btn_PrintReceipt = new System.Windows.Forms.Button();
            this.OfferingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffererName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Star = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Offerings)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_OfferingCode
            // 
            this.txt_OfferingCode.Location = new System.Drawing.Point(12, 129);
            this.txt_OfferingCode.Name = "txt_OfferingCode";
            this.txt_OfferingCode.Size = new System.Drawing.Size(179, 20);
            this.txt_OfferingCode.TabIndex = 0;
            this.txt_OfferingCode.Leave += new System.EventHandler(this.txt_OfferingCode_Leave);
            // 
            // txt_StarSign
            // 
            this.txt_StarSign.Location = new System.Drawing.Point(211, 129);
            this.txt_StarSign.Name = "txt_StarSign";
            this.txt_StarSign.Size = new System.Drawing.Size(130, 20);
            this.txt_StarSign.TabIndex = 1;
            this.txt_StarSign.Leave += new System.EventHandler(this.txt_StarSign_Leave);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(362, 114);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(130, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // cmb_Offering
            // 
            this.cmb_Offering.FormattingEnabled = true;
            this.cmb_Offering.Location = new System.Drawing.Point(12, 96);
            this.cmb_Offering.Name = "cmb_Offering";
            this.cmb_Offering.Size = new System.Drawing.Size(179, 21);
            this.cmb_Offering.TabIndex = 3;
            this.cmb_Offering.SelectedIndexChanged += new System.EventHandler(this.cmb_Offering_SelectedIndexChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Close.Location = new System.Drawing.Point(581, 1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 20);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // cmb_Star
            // 
            this.cmb_Star.FormattingEnabled = true;
            this.cmb_Star.Location = new System.Drawing.Point(211, 96);
            this.cmb_Star.Name = "cmb_Star";
            this.cmb_Star.Size = new System.Drawing.Size(130, 21);
            this.cmb_Star.TabIndex = 16;
            this.cmb_Star.SelectedIndexChanged += new System.EventHandler(this.cmb_Star_SelectedIndexChanged);
            // 
            // lbl_Offering
            // 
            this.lbl_Offering.AutoSize = true;
            this.lbl_Offering.ForeColor = System.Drawing.Color.White;
            this.lbl_Offering.Location = new System.Drawing.Point(61, 72);
            this.lbl_Offering.Name = "lbl_Offering";
            this.lbl_Offering.Size = new System.Drawing.Size(60, 13);
            this.lbl_Offering.TabIndex = 17;
            this.lbl_Offering.Text = "വഴിപാട് ";
            // 
            // lbl_Star
            // 
            this.lbl_Star.AutoSize = true;
            this.lbl_Star.ForeColor = System.Drawing.Color.White;
            this.lbl_Star.Location = new System.Drawing.Point(211, 72);
            this.lbl_Star.Name = "lbl_Star";
            this.lbl_Star.Size = new System.Drawing.Size(62, 13);
            this.lbl_Star.TabIndex = 17;
            this.lbl_Star.Text = "നക്ഷത്രം";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(509, 112);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(81, 25);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "ചേർക്കു";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dg_Offerings
            // 
            this.dg_Offerings.AllowUserToAddRows = false;
            this.dg_Offerings.AllowUserToDeleteRows = false;
            this.dg_Offerings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Offerings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfferingName,
            this.OffererName,
            this.Star,
            this.Price,
            this.DeleteButton});
            this.dg_Offerings.Location = new System.Drawing.Point(12, 189);
            this.dg_Offerings.Name = "dg_Offerings";
            this.dg_Offerings.ReadOnly = true;
            this.dg_Offerings.Size = new System.Drawing.Size(576, 181);
            this.dg_Offerings.TabIndex = 20;
            this.dg_Offerings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Offerings_CellContentClick);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Header.Location = new System.Drawing.Point(208, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(106, 13);
            this.lbl_Header.TabIndex = 21;
            this.lbl_Header.Text = "വഴിപാട് രസീതി";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "പേര്";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(25, 396);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(81, 13);
            this.lbl_total.TabIndex = 22;
            this.lbl_total.Text = "ആകെ തുക";
            // 
            // lbl_TotalSum
            // 
            this.lbl_TotalSum.AutoSize = true;
            this.lbl_TotalSum.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalSum.Location = new System.Drawing.Point(139, 396);
            this.lbl_TotalSum.Name = "lbl_TotalSum";
            this.lbl_TotalSum.Size = new System.Drawing.Size(0, 13);
            this.lbl_TotalSum.TabIndex = 23;
            // 
            // btn_PrintReceipt
            // 
            this.btn_PrintReceipt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_PrintReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btn_PrintReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_PrintReceipt.FlatAppearance.BorderSize = 0;
            this.btn_PrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintReceipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_PrintReceipt.Location = new System.Drawing.Point(459, 393);
            this.btn_PrintReceipt.Name = "btn_PrintReceipt";
            this.btn_PrintReceipt.Size = new System.Drawing.Size(115, 45);
            this.btn_PrintReceipt.TabIndex = 4;
            this.btn_PrintReceipt.Text = "രസീതി അടിക്കു ";
            this.btn_PrintReceipt.UseVisualStyleBackColor = false;
            this.btn_PrintReceipt.Click += new System.EventHandler(this.btn_PrintReceipt_Click);
            // 
            // OfferingName
            // 
            this.OfferingName.DataPropertyName = "OfferingName";
            this.OfferingName.HeaderText = "വഴിപാട്";
            this.OfferingName.Name = "OfferingName";
            this.OfferingName.ReadOnly = true;
            this.OfferingName.Width = 116;
            // 
            // OffererName
            // 
            this.OffererName.DataPropertyName = "Name";
            this.OffererName.HeaderText = "പേര്";
            this.OffererName.Name = "OffererName";
            this.OffererName.ReadOnly = true;
            this.OffererName.Width = 115;
            // 
            // Star
            // 
            this.Star.DataPropertyName = "StarSignName";
            this.Star.HeaderText = "നാൾ";
            this.Star.Name = "Star";
            this.Star.ReadOnly = true;
            this.Star.Width = 115;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "വില";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 115;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "നീക്കം ചെയ്യുക";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "ഡിലീറ്റ്";
            this.DeleteButton.ToolTipText = "നീക്കം ചെയ്യുക";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            // 
            // OfferingTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lbl_TotalSum);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.dg_Offerings);
            this.Controls.Add(this.btn_PrintReceipt);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Star);
            this.Controls.Add(this.lbl_Offering);
            this.Controls.Add(this.cmb_Star);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.cmb_Offering);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_StarSign);
            this.Controls.Add(this.txt_OfferingCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OfferingTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfferingTransaction";
            this.Load += new System.EventHandler(this.OfferingTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Offerings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_OfferingCode;
        private System.Windows.Forms.TextBox txt_StarSign;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox cmb_Offering;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox cmb_Star;
        private System.Windows.Forms.Label lbl_Offering;
        private System.Windows.Forms.Label lbl_Star;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dg_Offerings;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_TotalSum;
        private System.Windows.Forms.Button btn_PrintReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffererName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Star;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}