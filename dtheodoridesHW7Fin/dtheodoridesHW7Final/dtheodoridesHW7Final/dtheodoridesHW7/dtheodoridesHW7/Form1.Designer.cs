namespace dtheodoridesHW7
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboNamesOfSoftwareApplications = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbAddMaintenancePackage = new System.Windows.Forms.RadioButton();
            this.rdbDeclinedMaintenancePackage = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculateCharge = new System.Windows.Forms.Button();
            this.btnDisplaySalesReport = new System.Windows.Forms.Button();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNumberOfLicenses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(106, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name :";
            // 
            // cboNamesOfSoftwareApplications
            // 
            this.cboNamesOfSoftwareApplications.FormattingEnabled = true;
            this.cboNamesOfSoftwareApplications.Location = new System.Drawing.Point(171, 42);
            this.cboNamesOfSoftwareApplications.Name = "cboNamesOfSoftwareApplications";
            this.cboNamesOfSoftwareApplications.Size = new System.Drawing.Size(121, 21);
            this.cboNamesOfSoftwareApplications.TabIndex = 2;
            this.cboNamesOfSoftwareApplications.Text = "Select Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Names of Software Applications :";
            // 
            // rdbAddMaintenancePackage
            // 
            this.rdbAddMaintenancePackage.AutoSize = true;
            this.rdbAddMaintenancePackage.Location = new System.Drawing.Point(6, 19);
            this.rdbAddMaintenancePackage.Name = "rdbAddMaintenancePackage";
            this.rdbAddMaintenancePackage.Size = new System.Drawing.Size(161, 17);
            this.rdbAddMaintenancePackage.TabIndex = 4;
            this.rdbAddMaintenancePackage.TabStop = true;
            this.rdbAddMaintenancePackage.Text = "Add Maintenance Package :";
            this.rdbAddMaintenancePackage.UseVisualStyleBackColor = true;
            // 
            // rdbDeclinedMaintenancePackage
            // 
            this.rdbDeclinedMaintenancePackage.AutoSize = true;
            this.rdbDeclinedMaintenancePackage.Location = new System.Drawing.Point(6, 42);
            this.rdbDeclinedMaintenancePackage.Name = "rdbDeclinedMaintenancePackage";
            this.rdbDeclinedMaintenancePackage.Size = new System.Drawing.Size(184, 17);
            this.rdbDeclinedMaintenancePackage.TabIndex = 5;
            this.rdbDeclinedMaintenancePackage.TabStop = true;
            this.rdbDeclinedMaintenancePackage.Text = "Declined Maintenance Package :";
            this.rdbDeclinedMaintenancePackage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDeclinedMaintenancePackage);
            this.groupBox1.Controls.Add(this.rdbAddMaintenancePackage);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Maintenance Option :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCalculateCharge
            // 
            this.btnCalculateCharge.Location = new System.Drawing.Point(18, 161);
            this.btnCalculateCharge.Name = "btnCalculateCharge";
            this.btnCalculateCharge.Size = new System.Drawing.Size(112, 36);
            this.btnCalculateCharge.TabIndex = 7;
            this.btnCalculateCharge.Text = "Calculate Charge :";
            this.btnCalculateCharge.UseVisualStyleBackColor = true;
            this.btnCalculateCharge.Click += new System.EventHandler(this.btnCalculateCharge_Click);
            // 
            // btnDisplaySalesReport
            // 
            this.btnDisplaySalesReport.Location = new System.Drawing.Point(150, 162);
            this.btnDisplaySalesReport.Name = "btnDisplaySalesReport";
            this.btnDisplaySalesReport.Size = new System.Drawing.Size(121, 35);
            this.btnDisplaySalesReport.TabIndex = 8;
            this.btnDisplaySalesReport.Text = "Display Sales Report :";
            this.btnDisplaySalesReport.UseVisualStyleBackColor = true;
            this.btnDisplaySalesReport.Click += new System.EventHandler(this.btnDisplaySalesReport_Click);
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(296, 162);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(105, 35);
            this.btnFindCustomer.TabIndex = 9;
            this.btnFindCustomer.Text = "Find Customer :";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(18, 203);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(513, 264);
            this.lstDisplay.TabIndex = 10;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(564, 259);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(661, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNumberOfLicenses
            // 
            this.txtNumberOfLicenses.Location = new System.Drawing.Point(422, 99);
            this.txtNumberOfLicenses.Name = "txtNumberOfLicenses";
            this.txtNumberOfLicenses.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfLicenses.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Number of licenses to be purchased :";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumberOfLicenses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.btnDisplaySalesReport);
            this.Controls.Add(this.btnCalculateCharge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboNamesOfSoftwareApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNamesOfSoftwareApplications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbAddMaintenancePackage;
        private System.Windows.Forms.RadioButton rdbDeclinedMaintenancePackage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculateCharge;
        private System.Windows.Forms.Button btnDisplaySalesReport;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNumberOfLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider erpError;
    }
}

