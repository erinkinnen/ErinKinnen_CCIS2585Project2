namespace ErinKinnen_CCIS2585Project2
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
            this.btnBrowseEmpData = new System.Windows.Forms.Button();
            this.btnEnterPayrollData = new System.Windows.Forms.Button();
            this.btnForm1Exit = new System.Windows.Forms.Button();
            this.lblPayrollSystem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseEmpData
            // 
            this.btnBrowseEmpData.Location = new System.Drawing.Point(20, 57);
            this.btnBrowseEmpData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowseEmpData.Name = "btnBrowseEmpData";
            this.btnBrowseEmpData.Size = new System.Drawing.Size(200, 31);
            this.btnBrowseEmpData.TabIndex = 0;
            this.btnBrowseEmpData.Text = "Browse Employee Data";
            this.btnBrowseEmpData.UseVisualStyleBackColor = true;
            this.btnBrowseEmpData.Click += new System.EventHandler(this.btnBrowseEmpData_Click);
            // 
            // btnEnterPayrollData
            // 
            this.btnEnterPayrollData.Location = new System.Drawing.Point(20, 118);
            this.btnEnterPayrollData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnterPayrollData.Name = "btnEnterPayrollData";
            this.btnEnterPayrollData.Size = new System.Drawing.Size(200, 31);
            this.btnEnterPayrollData.TabIndex = 1;
            this.btnEnterPayrollData.Text = "Enter Payroll Data";
            this.btnEnterPayrollData.UseVisualStyleBackColor = true;
            // 
            // btnForm1Exit
            // 
            this.btnForm1Exit.Location = new System.Drawing.Point(20, 225);
            this.btnForm1Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForm1Exit.Name = "btnForm1Exit";
            this.btnForm1Exit.Size = new System.Drawing.Size(200, 31);
            this.btnForm1Exit.TabIndex = 2;
            this.btnForm1Exit.Text = "Exit";
            this.btnForm1Exit.UseVisualStyleBackColor = true;
            this.btnForm1Exit.Click += new System.EventHandler(this.btnForm1Exit_Click);
            // 
            // lblPayrollSystem
            // 
            this.lblPayrollSystem.AutoSize = true;
            this.lblPayrollSystem.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrollSystem.Location = new System.Drawing.Point(61, 13);
            this.lblPayrollSystem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayrollSystem.Name = "lblPayrollSystem";
            this.lblPayrollSystem.Size = new System.Drawing.Size(120, 19);
            this.lblPayrollSystem.TabIndex = 3;
            this.lblPayrollSystem.Text = "Payroll System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 304);
            this.Controls.Add(this.lblPayrollSystem);
            this.Controls.Add(this.btnForm1Exit);
            this.Controls.Add(this.btnEnterPayrollData);
            this.Controls.Add(this.btnBrowseEmpData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Payroll System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseEmpData;
        private System.Windows.Forms.Button btnEnterPayrollData;
        private System.Windows.Forms.Button btnForm1Exit;
        private System.Windows.Forms.Label lblPayrollSystem;
    }
}

