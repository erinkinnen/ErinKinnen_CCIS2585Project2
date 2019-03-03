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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnForm2Exit = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblErrorForm2 = new System.Windows.Forms.Label();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.grpEmployee.SuspendLayout();
            this.grpPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrowseEmployee
            // 
            this.lblBrowseEmployee.AutoSize = true;
            this.lblBrowseEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowseEmployee.Location = new System.Drawing.Point(194, 19);
            this.lblBrowseEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrowseEmployee.Name = "lblBrowseEmployee";
            this.lblBrowseEmployee.Size = new System.Drawing.Size(143, 19);
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
            this.grpEmployee.Location = new System.Drawing.Point(59, 58);
            this.grpEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEmployee.Size = new System.Drawing.Size(404, 162);
            this.grpEmployee.TabIndex = 1;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(213, 101);
            this.txtPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(76, 20);
            this.txtPay.TabIndex = 9;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(171, 105);
            this.lblPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(32, 13);
            this.lblPay.TabIndex = 8;
            this.lblPay.Text = "Pay:";
            // 
            // txtSSAN
            // 
            this.txtSSAN.Location = new System.Drawing.Point(83, 102);
            this.txtSSAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSSAN.Name = "txtSSAN";
            this.txtSSAN.Size = new System.Drawing.Size(76, 20);
            this.txtSSAN.TabIndex = 7;
            // 
            // lblSSAN
            // 
            this.lblSSAN.AutoSize = true;
            this.lblSSAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSAN.Location = new System.Drawing.Point(14, 102);
            this.lblSSAN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSAN.Name = "lblSSAN";
            this.lblSSAN.Size = new System.Drawing.Size(44, 13);
            this.lblSSAN.TabIndex = 6;
            this.lblSSAN.Text = "SSAN:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(213, 65);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(76, 20);
            this.txtLName.TabIndex = 5;
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(171, 65);
            this.txtMI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(29, 20);
            this.txtMI.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(83, 66);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(76, 20);
            this.txtFName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 66);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(12, 32);
            this.lblIDNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(71, 13);
            this.lblIDNumber.TabIndex = 0;
            this.lblIDNumber.Text = "ID Number:";
            this.lblIDNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(83, 32);
            this.txtIDNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(76, 20);
            this.txtIDNumber.TabIndex = 1;
            // 
            // grpPayroll
            // 
            this.grpPayroll.Controls.Add(this.dgvPayroll);
            this.grpPayroll.Location = new System.Drawing.Point(17, 261);
            this.grpPayroll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPayroll.Name = "grpPayroll";
            this.grpPayroll.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPayroll.Size = new System.Drawing.Size(488, 145);
            this.grpPayroll.TabIndex = 2;
            this.grpPayroll.TabStop = false;
            this.grpPayroll.Text = "Payroll";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(114, 411);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 36);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnForm2Exit
            // 
            this.btnForm2Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm2Exit.Location = new System.Drawing.Point(421, 411);
            this.btnForm2Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForm2Exit.Name = "btnForm2Exit";
            this.btnForm2Exit.Size = new System.Drawing.Size(85, 36);
            this.btnForm2Exit.TabIndex = 4;
            this.btnForm2Exit.Text = "Exit";
            this.btnForm2Exit.UseVisualStyleBackColor = true;
            this.btnForm2Exit.Click += new System.EventHandler(this.btnExitForm2_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(308, 411);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(85, 36);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = "Last >>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(211, 411);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 36);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(17, 411);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(85, 36);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "<< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblErrorForm2
            // 
            this.lblErrorForm2.AutoSize = true;
            this.lblErrorForm2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorForm2.Location = new System.Drawing.Point(56, 232);
            this.lblErrorForm2.Name = "lblErrorForm2";
            this.lblErrorForm2.Size = new System.Drawing.Size(0, 13);
            this.lblErrorForm2.TabIndex = 8;
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.Location = new System.Drawing.Point(5, 18);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.Size = new System.Drawing.Size(478, 122);
            this.dgvPayroll.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 471);
            this.Controls.Add(this.lblErrorForm2);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnForm2Exit);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.grpPayroll);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.lblBrowseEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Browse Payroll";
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
    }
}