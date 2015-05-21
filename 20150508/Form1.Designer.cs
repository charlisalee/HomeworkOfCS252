namespace _20150508
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
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.setSalaryButtonA = new System.Windows.Forms.Button();
            this.setSalaryButtonB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(48, 53);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 0;
            // 
            // setSalaryButtonA
            // 
            this.setSalaryButtonA.Location = new System.Drawing.Point(184, 53);
            this.setSalaryButtonA.Name = "setSalaryButtonA";
            this.setSalaryButtonA.Size = new System.Drawing.Size(75, 23);
            this.setSalaryButtonA.TabIndex = 1;
            this.setSalaryButtonA.Text = "SalaryA";
            this.setSalaryButtonA.UseVisualStyleBackColor = true;
            // 
            // setSalaryButtonB
            // 
            this.setSalaryButtonB.Location = new System.Drawing.Point(185, 140);
            this.setSalaryButtonB.Name = "setSalaryButtonB";
            this.setSalaryButtonB.Size = new System.Drawing.Size(75, 23);
            this.setSalaryButtonB.TabIndex = 2;
            this.setSalaryButtonB.Text = "SalaryB";
            this.setSalaryButtonB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.setSalaryButtonB);
            this.Controls.Add(this.setSalaryButtonA);
            this.Controls.Add(this.salaryTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button setSalaryButtonA;
        private System.Windows.Forms.Button setSalaryButtonB;

    }
}

