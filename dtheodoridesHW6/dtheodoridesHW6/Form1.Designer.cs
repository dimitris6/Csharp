namespace dtheodoridesHW6
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAmountOfStorageInGB = new System.Windows.Forms.TextBox();
            this.txtYesOrNo = new System.Windows.Forms.TextBox();
            this.btnCalculateMonthlyBill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.erpYesOrNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCustomerName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpYesOrNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCustomerName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(138, 59);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerName_Validating);
            // 
            // txtAmountOfStorageInGB
            // 
            this.txtAmountOfStorageInGB.Location = new System.Drawing.Point(138, 129);
            this.txtAmountOfStorageInGB.Name = "txtAmountOfStorageInGB";
            this.txtAmountOfStorageInGB.Size = new System.Drawing.Size(100, 20);
            this.txtAmountOfStorageInGB.TabIndex = 1;
            this.txtAmountOfStorageInGB.TextChanged += new System.EventHandler(this.txtAmountOfStorageInGB_TextChanged);
            this.txtAmountOfStorageInGB.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountOfStorageInGB_Validating);
            // 
            // txtYesOrNo
            // 
            this.txtYesOrNo.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes ",
            "No"});
            this.txtYesOrNo.Location = new System.Drawing.Point(138, 196);
            this.txtYesOrNo.Name = "txtYesOrNo";
            this.txtYesOrNo.Size = new System.Drawing.Size(100, 20);
            this.txtYesOrNo.TabIndex = 2;
            this.txtYesOrNo.TextChanged += new System.EventHandler(this.txtYesOrNo_TextChanged);
            this.txtYesOrNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtYesOrNo_Validating);
            // 
            // btnCalculateMonthlyBill
            // 
            this.btnCalculateMonthlyBill.Location = new System.Drawing.Point(126, 269);
            this.btnCalculateMonthlyBill.Name = "btnCalculateMonthlyBill";
            this.btnCalculateMonthlyBill.Size = new System.Drawing.Size(112, 46);
            this.btnCalculateMonthlyBill.TabIndex = 3;
            this.btnCalculateMonthlyBill.Text = "Display Monthly Bill :";
            this.btnCalculateMonthlyBill.UseVisualStyleBackColor = true;
            this.btnCalculateMonthlyBill.Click += new System.EventHandler(this.btnCalculateMonthlyBill_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(417, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(545, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount of Storage in GB :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yes / No :";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(277, 12);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(463, 303);
            this.lstDisplay.TabIndex = 9;
            this.lstDisplay.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // erpYesOrNo
            // 
            this.erpYesOrNo.ContainerControl = this;
            // 
            // erpCustomerName
            // 
            this.erpCustomerName.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 401);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateMonthlyBill);
            this.Controls.Add(this.txtYesOrNo);
            this.Controls.Add(this.txtAmountOfStorageInGB);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "Form1";
            this.Text = "CloudDrive";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpYesOrNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCustomerName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAmountOfStorageInGB;
        private System.Windows.Forms.TextBox txtYesOrNo;
        private System.Windows.Forms.Button btnCalculateMonthlyBill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ErrorProvider erpYesOrNo;
        private System.Windows.Forms.ErrorProvider erpCustomerName;
    }
}

