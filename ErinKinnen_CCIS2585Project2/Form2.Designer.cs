namespace ErinKinnen_CCIS2585Project2
{
    partial class Form2
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
            this.lblBrowseEmployee = new System.Windows.Forms.Label();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtSSAN = new System.Windows.Forms.TextBox();
            this.lblSSAN = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.grpPayroll = new System.Windows.Forms.GroupBox();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnForm2Exit = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblErrorForm2 = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            this.grpEmployee.SuspendLayout();
            this.grpPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrowseEmployee
            // 
            this.lblBrowseEmployee.AutoSize = true;
            this.lblBrowseEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowseEmployee.Location = new System.Drawing.Point(259, 23);
            this.lblBrowseEmployee.Name = "lblBrowseEmployee";
            this.lblBrowseEmployee.Size = new System.Drawing.Size(181, 26);
            this.lblBrowseEmployee.TabIndex = 0;
            this.lblBrowseEmployee.Text = "Browse Employee";
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.txtPay);
            this.grpEmployee.Controls.Add(this.lblPay);
            this.grpEmployee.Controls.Add(this.txtSSAN);
            this.grpEmployee.Controls.Add(this.lblSSAN);
            this.grpEmployee.Controls.Add(this.txtLName);
            this.grpEmployee.Controls.Add(this.txtMI);
            this.grpEmployee.Controls.Add(this.txtFName);
            this.grpEmployee.Controls.Add(this.lblName);
            this.grpEmployee.Controls.Add(this.lblIDNumber);
            this.grpEmployee.Controls.Add(this.txtIDNumber);
            this.grpEmployee.Location = new System.Drawing.Point(79, 71);
            this.grpEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmployee.Size = new System.Drawing.Size(539, 199);
            this.grpEmployee.TabIndex = 1;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(284, 124);
            this.txtPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 22);
            this.txtPay.TabIndex = 9;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(228, 129);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(40, 17);
            this.lblPay.TabIndex = 8;
            this.lblPay.Text = "Pay:";
            // 
            // txtSSAN
            // 
            this.txtSSAN.Location = new System.Drawing.Point(111, 126);
            this.txtSSAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSSAN.Name = "txtSSAN";
            this.txtSSAN.Size = new System.Drawing.Size(100, 22);
            this.txtSSAN.TabIndex = 7;
            // 
            // lblSSAN
            // 
            this.lblSSAN.AutoSize = true;
            this.lblSSAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSAN.Location = new System.Drawing.Point(19, 126);
            this.lblSSAN.Name = "lblSSAN";
            this.lblSSAN.Size = new System.Drawing.Size(54, 17);
            this.lblSSAN.TabIndex = 6;
            this.lblSSAN.Text = "SSAN:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(284, 80);
            this.txtLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 22);
            this.txtLName.TabIndex = 5;
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(228, 80);
            this.txtMI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(37, 22);
            this.txtMI.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(111, 81);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 22);
            this.txtFName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(16, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(16, 39);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(89, 17);
            this.lblIDNumber.TabIndex = 0;
            this.lblIDNumber.Text = "ID Number:";
            this.lblIDNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(111, 39);
            this.txtIDNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(100, 22);
            this.txtIDNumber.TabIndex = 1;
            // 
            // grpPayroll
            // 
            this.grpPayroll.Controls.Add(this.dgvPayroll);
            this.grpPayroll.Location = new System.Drawing.Point(23, 321);
            this.grpPayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPayroll.Name = "grpPayroll";
            this.grpPayroll.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPayroll.Size = new System.Drawing.Size(651, 178);
            this.grpPayroll.TabIndex = 2;
            this.grpPayroll.TabStop = false;
            this.grpPayroll.Text = "Payroll";
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.Location = new System.Drawing.Point(7, 22);
            this.dgvPayroll.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.Size = new System.Drawing.Size(637, 150);
            this.dgvPayroll.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(152, 506);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(113, 44);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnForm2Exit
            // 
            this.btnForm2Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm2Exit.Location = new System.Drawing.Point(561, 506);
            this.btnForm2Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForm2Exit.Name = "btnForm2Exit";
            this.btnForm2Exit.Size = new System.Drawing.Size(113, 44);
            this.btnForm2Exit.TabIndex = 4;
            this.btnForm2Exit.Text = "Exit";
            this.btnForm2Exit.UseVisualStyleBackColor = true;
            this.btnForm2Exit.Click += new System.EventHandler(this.btnExitForm2_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(411, 506);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(113, 44);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = "Last >>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(281, 506);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 44);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(23, 506);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(113, 44);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "<< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblErrorForm2
            // 
            this.lblErrorForm2.AutoSize = true;
            this.lblErrorForm2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorForm2.Location = new System.Drawing.Point(75, 286);
            this.lblErrorForm2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorForm2.Name = "lblErrorForm2";
            this.lblErrorForm2.Size = new System.Drawing.Size(0, 17);
            this.lblErrorForm2.TabIndex = 8;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(59, 20);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(0, 25);
            this.lbltest.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 580);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.lblErrorForm2);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnForm2Exit);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.grpPayroll);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.lblBrowseEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Browse Payroll";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.grpPayroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrowseEmployee;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtSSAN;
        private System.Windows.Forms.Label lblSSAN;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.GroupBox grpPayroll;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnForm2Exit;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblErrorForm2;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.Label lbltest;
    }
}