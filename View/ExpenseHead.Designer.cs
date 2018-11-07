namespace View
{
    partial class ExpenseHead
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbl_Exp_Details = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.lbl_SourceExpense = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_ExpenseHead = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseHeadName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ExpenseHead)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Close.Location = new System.Drawing.Point(568, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 20);
            this.btn_Close.TabIndex = 21;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMsg.Location = new System.Drawing.Point(378, 220);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(153, 13);
            this.lblMsg.TabIndex = 20;
            this.lblMsg.Text = "Label for showing the message";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(268, 162);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 20);
            this.txtDescription.TabIndex = 19;
            // 
            // lbl_Exp_Details
            // 
            this.lbl_Exp_Details.AutoSize = true;
            this.lbl_Exp_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exp_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_Exp_Details.Location = new System.Drawing.Point(100, 169);
            this.lbl_Exp_Details.Name = "lbl_Exp_Details";
            this.lbl_Exp_Details.Size = new System.Drawing.Size(113, 13);
            this.lbl_Exp_Details.TabIndex = 18;
            this.lbl_Exp_Details.Text = "വകുപ്പ് വിവരണം";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(381, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "ചേർക്കുക";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtExpense
            // 
            this.txtExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpense.Location = new System.Drawing.Point(268, 136);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(260, 20);
            this.txtExpense.TabIndex = 16;
            // 
            // lbl_SourceExpense
            // 
            this.lbl_SourceExpense.AutoSize = true;
            this.lbl_SourceExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SourceExpense.ForeColor = System.Drawing.Color.White;
            this.lbl_SourceExpense.Location = new System.Drawing.Point(100, 143);
            this.lbl_SourceExpense.Name = "lbl_SourceExpense";
            this.lbl_SourceExpense.Size = new System.Drawing.Size(91, 13);
            this.lbl_SourceExpense.TabIndex = 15;
            this.lbl_SourceExpense.Text = "ചിലവ് വകുപ്പ്";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ചിലവ് വകുപ്പുകൾ";
            // 
            // dg_ExpenseHead
            // 
            this.dg_ExpenseHead.AllowUserToAddRows = false;
            this.dg_ExpenseHead.AllowUserToDeleteRows = false;
            this.dg_ExpenseHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ExpenseHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ExpenseHeadName,
            this.ExpenseDescription,
            this.Delete});
            this.dg_ExpenseHead.Location = new System.Drawing.Point(12, 266);
            this.dg_ExpenseHead.Name = "dg_ExpenseHead";
            this.dg_ExpenseHead.ReadOnly = true;
            this.dg_ExpenseHead.Size = new System.Drawing.Size(576, 150);
            this.dg_ExpenseHead.TabIndex = 22;
            this.dg_ExpenseHead.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ExpenseHead_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ExpenseHeadId";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ExpenseHeadName
            // 
            this.ExpenseHeadName.DataPropertyName = "ExpenseHeadName";
            this.ExpenseHeadName.HeaderText = "ചിലവ് വകുപ്പ്";
            this.ExpenseHeadName.Name = "ExpenseHeadName";
            this.ExpenseHeadName.ReadOnly = true;
            this.ExpenseHeadName.Width = 225;
            // 
            // ExpenseDescription
            // 
            this.ExpenseDescription.DataPropertyName = "ExpenseDescription";
            this.ExpenseDescription.HeaderText = "വകുപ്പ് വിവരണം";
            this.ExpenseDescription.Name = "ExpenseDescription";
            this.ExpenseDescription.ReadOnly = true;
            this.ExpenseDescription.Width = 280;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "നീക്കം ചെയ്യുക";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "ഡിലീറ്റ്";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 71;
            // 
            // ExpenseHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.dg_ExpenseHead);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbl_Exp_Details);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SourceExpense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseHead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Head";
            this.Load += new System.EventHandler(this.ExpenseHead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ExpenseHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbl_Exp_Details;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label lbl_SourceExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_ExpenseHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseHeadName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseDescription;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}