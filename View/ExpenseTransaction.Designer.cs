namespace View
{
    partial class ExpenseTransaction
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
            this.cmbExpenseHead = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveExpenseTransaction = new System.Windows.Forms.Button();
            this.txtPriceExpenseTransaction = new System.Windows.Forms.TextBox();
            this.txtExpenseDescription = new System.Windows.Forms.TextBox();
            this.DateExpenseTransaction = new System.Windows.Forms.DateTimePicker();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbExpenseHead
            // 
            this.cmbExpenseHead.FormattingEnabled = true;
            this.cmbExpenseHead.Location = new System.Drawing.Point(258, 126);
            this.cmbExpenseHead.Name = "cmbExpenseHead";
            this.cmbExpenseHead.Size = new System.Drawing.Size(260, 21);
            this.cmbExpenseHead.TabIndex = 0;
            this.cmbExpenseHead.Enter += new System.EventHandler(this.cmbExpenseHead_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ExpenseHead";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Tranasaction";
            // 
            // btnSaveExpenseTransaction
            // 
            this.btnSaveExpenseTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnSaveExpenseTransaction.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSaveExpenseTransaction.Location = new System.Drawing.Point(371, 243);
            this.btnSaveExpenseTransaction.Name = "btnSaveExpenseTransaction";
            this.btnSaveExpenseTransaction.Size = new System.Drawing.Size(147, 19);
            this.btnSaveExpenseTransaction.TabIndex = 5;
            this.btnSaveExpenseTransaction.Text = "Save";
            this.btnSaveExpenseTransaction.UseVisualStyleBackColor = false;
            this.btnSaveExpenseTransaction.Click += new System.EventHandler(this.btnSaveExpenseTransaction_Click);
            // 
            // txtPriceExpenseTransaction
            // 
            this.txtPriceExpenseTransaction.Location = new System.Drawing.Point(258, 154);
            this.txtPriceExpenseTransaction.Name = "txtPriceExpenseTransaction";
            this.txtPriceExpenseTransaction.Size = new System.Drawing.Size(260, 20);
            this.txtPriceExpenseTransaction.TabIndex = 6;
            // 
            // txtExpenseDescription
            // 
            this.txtExpenseDescription.Location = new System.Drawing.Point(258, 180);
            this.txtExpenseDescription.Name = "txtExpenseDescription";
            this.txtExpenseDescription.Size = new System.Drawing.Size(260, 20);
            this.txtExpenseDescription.TabIndex = 7;
            // 
            // DateExpenseTransaction
            // 
            this.DateExpenseTransaction.Location = new System.Drawing.Point(258, 206);
            this.DateExpenseTransaction.Name = "DateExpenseTransaction";
            this.DateExpenseTransaction.Size = new System.Drawing.Size(260, 20);
            this.DateExpenseTransaction.TabIndex = 8;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(340, 279);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(178, 15);
            this.lblMsg.TabIndex = 14;
            this.lblMsg.Text = "Label for showing the message";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Close.Location = new System.Drawing.Point(630, 1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 20);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ExpenseTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(652, 418);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.DateExpenseTransaction);
            this.Controls.Add(this.txtExpenseDescription);
            this.Controls.Add(this.txtPriceExpenseTransaction);
            this.Controls.Add(this.btnSaveExpenseTransaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbExpenseHead);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseTransaction";
            this.Text = "ExpenseReport";
            this.Load += new System.EventHandler(this.ExpenseTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbExpenseHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveExpenseTransaction;
        private System.Windows.Forms.TextBox txtPriceExpenseTransaction;
        private System.Windows.Forms.TextBox txtExpenseDescription;
        private System.Windows.Forms.DateTimePicker DateExpenseTransaction;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btn_Close;
    }
}