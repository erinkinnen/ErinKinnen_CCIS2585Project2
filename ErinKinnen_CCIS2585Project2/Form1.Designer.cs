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
            this.btnBrowseEmpData.Location = new System.Drawing.Point(27, 70);
            this.btnBrowseEmpData.Name = "btnBrowseEmpData";
            this.btnBrowseEmpData.Size = new System.Drawing.Size(267, 38);
            this.btnBrowseEmpData.TabIndex = 0;
            this.btnBrowseEmpData.Text = "Browse Employee Data";
            this.btnBrowseEmpData.UseVisualStyleBackColor = true;
            // 
            // btnEnterPayrollData
            // 
            this.btnEnterPayrollData.Location = new System.Drawing.Point(27, 145);
            this.btnEnterPayrollData.Name = "btnEnterPayrollData";
            this.btnEnterPayrollData.Size = new System.Drawing.Size(267, 38);
            this.btnEnterPayrollData.TabIndex = 1;
            this.btnEnterPayrollData.Text = "Enter Payroll Data";
            this.btnEnterPayrollData.UseVisualStyleBackColor = true;
            // 
            // btnForm1Exit
            // 
            this.btnForm1Exit.Location = new System.Drawing.Point(27, 277);
            this.btnForm1Exit.Name = "btnForm1Exit";
            this.btnForm1Exit.Size = new System.Drawing.Size(267, 38);
            this.btnForm1Exit.TabIndex = 2;
            this.btnForm1Exit.Text = "Exit";
            this.btnForm1Exit.UseVisualStyleBackColor = true;
            // 
            // lblPayrollSystem
            // 
            this.lblPayrollSystem.AutoSize = true;
            this.lblPayrollSystem.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrollSystem.Location = new System.Drawing.Point(81, 16);
            this.lblPayrollSystem.Name = "lblPayrollSystem";
            this.lblPayrollSystem.Size = new System.Drawing.Size(153, 26);
            this.lblPayrollSystem.TabIndex = 3;
            this.lblPayrollSystem.Text = "Payroll System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 374);
            this.Controls.Add(this.lblPayrollSystem);
            this.Controls.Add(this.btnForm1Exit);
            this.Controls.Add(this.btnEnterPayrollData);
            this.Controls.Add(this.btnBrowseEmpData);
            this.Name = "Form1";
            this.Text = "Payroll System";
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

