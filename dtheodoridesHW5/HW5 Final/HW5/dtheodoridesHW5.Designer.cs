namespace HW5
{
    partial class dtheodoridesHW5
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
            this.btnStraightLineMethod = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDescriptionOfItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearOfPurchase = new System.Windows.Forms.TextBox();
            this.txtCostOfItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfYearsToBeDepreciated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepreciationRate = new System.Windows.Forms.TextBox();
            this.btnDecliningBalanceMethod = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStraightLineMethod
            // 
            this.btnStraightLineMethod.Location = new System.Drawing.Point(89, 471);
            this.btnStraightLineMethod.Name = "btnStraightLineMethod";
            this.btnStraightLineMethod.Size = new System.Drawing.Size(109, 34);
            this.btnStraightLineMethod.TabIndex = 0;
            this.btnStraightLineMethod.Text = "Straight Line Method :";
            this.btnStraightLineMethod.UseVisualStyleBackColor = true;
            this.btnStraightLineMethod.Click += new System.EventHandler(this.btnStraightLineMethod_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(649, 308);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 52);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(783, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDescriptionOfItem
            // 
            this.txtDescriptionOfItem.Location = new System.Drawing.Point(133, 35);
            this.txtDescriptionOfItem.Name = "txtDescriptionOfItem";
            this.txtDescriptionOfItem.Size = new System.Drawing.Size(100, 20);
            this.txtDescriptionOfItem.TabIndex = 3;
            this.txtDescriptionOfItem.TextChanged += new System.EventHandler(this.txtDescriptionOfItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description of Item :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year of Purchase :";
            // 
            // txtYearOfPurchase
            // 
            this.txtYearOfPurchase.Location = new System.Drawing.Point(133, 72);
            this.txtYearOfPurchase.Name = "txtYearOfPurchase";
            this.txtYearOfPurchase.Size = new System.Drawing.Size(100, 20);
            this.txtYearOfPurchase.TabIndex = 6;
            // 
            // txtCostOfItem
            // 
            this.txtCostOfItem.Location = new System.Drawing.Point(133, 110);
            this.txtCostOfItem.Name = "txtCostOfItem";
            this.txtCostOfItem.Size = new System.Drawing.Size(100, 20);
            this.txtCostOfItem.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost of Item :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of years to be Depreciated :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNumberOfYearsToBeDepreciated
            // 
            this.txtNumberOfYearsToBeDepreciated.Location = new System.Drawing.Point(210, 143);
            this.txtNumberOfYearsToBeDepreciated.Name = "txtNumberOfYearsToBeDepreciated";
            this.txtNumberOfYearsToBeDepreciated.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfYearsToBeDepreciated.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Depreciation Rate :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDepreciationRate
            // 
            this.txtDepreciationRate.Location = new System.Drawing.Point(471, 91);
            this.txtDepreciationRate.Name = "txtDepreciationRate";
            this.txtDepreciationRate.Size = new System.Drawing.Size(100, 20);
            this.txtDepreciationRate.TabIndex = 12;
            // 
            // btnDecliningBalanceMethod
            // 
            this.btnDecliningBalanceMethod.Location = new System.Drawing.Point(487, 472);
            this.btnDecliningBalanceMethod.Name = "btnDecliningBalanceMethod";
            this.btnDecliningBalanceMethod.Size = new System.Drawing.Size(118, 39);
            this.btnDecliningBalanceMethod.TabIndex = 13;
            this.btnDecliningBalanceMethod.Text = "Declining Balance Method :";
            this.btnDecliningBalanceMethod.UseVisualStyleBackColor = true;
            this.btnDecliningBalanceMethod.Click += new System.EventHandler(this.btnDecliningBalanceMethod_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.HorizontalScrollbar = true;
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(12, 248);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(622, 214);
            this.lstDisplay.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescriptionOfItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYearOfPurchase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumberOfYearsToBeDepreciated);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCostOfItem);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 194);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Straight Line Method";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtDepreciationRate);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 226);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "                                                                                 " +
    "                  Declining Balance Method";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtheodoridesHW5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnDecliningBalanceMethod);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStraightLineMethod);
            this.Name = "dtheodoridesHW5";
            this.Text = "HW5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStraightLineMethod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDescriptionOfItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYearOfPurchase;
        private System.Windows.Forms.TextBox txtCostOfItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfYearsToBeDepreciated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepreciationRate;
        private System.Windows.Forms.Button btnDecliningBalanceMethod;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

