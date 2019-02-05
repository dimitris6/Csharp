namespace AceAutoRentals
{
    partial class aceAutoRentals
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
            this.dtpStartOfRental = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtChargePerDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comAutoTypes = new System.Windows.Forms.ComboBox();
            this.btnFileToArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpStartOfRental
            // 
            this.dtpStartOfRental.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpStartOfRental.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartOfRental.Location = new System.Drawing.Point(92, 3);
            this.dtpStartOfRental.Name = "dtpStartOfRental";
            this.dtpStartOfRental.Size = new System.Drawing.Size(200, 20);
            this.dtpStartOfRental.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start of Rental :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Returned :";
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateReturned.Location = new System.Drawing.Point(92, 35);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(200, 20);
            this.dtpDateReturned.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(282, 264);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate :";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtChargePerDay
            // 
            this.txtChargePerDay.Location = new System.Drawing.Point(92, 71);
            this.txtChargePerDay.Name = "txtChargePerDay";
            this.txtChargePerDay.Size = new System.Drawing.Size(100, 20);
            this.txtChargePerDay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Charge per day :";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(267, 71);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(407, 173);
            this.lstDisplay.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(107, 173);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 8;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(83, 135);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 9;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Customer ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customer Name :";
            // 
            // comAutoTypes
            // 
            this.comAutoTypes.FormattingEnabled = true;
            this.comAutoTypes.Location = new System.Drawing.Point(86, 223);
            this.comAutoTypes.Name = "comAutoTypes";
            this.comAutoTypes.Size = new System.Drawing.Size(121, 21);
            this.comAutoTypes.TabIndex = 12;
            // 
            // btnFileToArray
            // 
            this.btnFileToArray.Location = new System.Drawing.Point(411, 264);
            this.btnFileToArray.Name = "btnFileToArray";
            this.btnFileToArray.Size = new System.Drawing.Size(127, 43);
            this.btnFileToArray.TabIndex = 13;
            this.btnFileToArray.Text = "File to Array:";
            this.btnFileToArray.UseVisualStyleBackColor = true;
            this.btnFileToArray.Click += new System.EventHandler(this.btnFileToArray_Click);
            // 
            // aceAutoRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 411);
            this.Controls.Add(this.btnFileToArray);
            this.Controls.Add(this.comAutoTypes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChargePerDay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartOfRental);
            this.Name = "aceAutoRentals";
            this.Text = "Ace Auto Rentals :";
            this.Load += new System.EventHandler(this.aceAutoRentals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartOfRental;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtChargePerDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comAutoTypes;
        private System.Windows.Forms.Button btnFileToArray;
    }
}

