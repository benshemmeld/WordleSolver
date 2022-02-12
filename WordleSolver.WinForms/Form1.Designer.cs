namespace WordleSolver.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPosition1 = new System.Windows.Forms.TextBox();
            this.txtPosition2 = new System.Windows.Forms.TextBox();
            this.txtPosition3 = new System.Windows.Forms.TextBox();
            this.txtPosition4 = new System.Windows.Forms.TextBox();
            this.txtPosition5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPosition1
            // 
            this.txtPosition1.BackColor = System.Drawing.Color.Gray;
            this.txtPosition1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition1.ForeColor = System.Drawing.Color.White;
            this.txtPosition1.Location = new System.Drawing.Point(32, 31);
            this.txtPosition1.MaxLength = 1;
            this.txtPosition1.Name = "txtPosition1";
            this.txtPosition1.Size = new System.Drawing.Size(91, 92);
            this.txtPosition1.TabIndex = 0;
            this.txtPosition1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPosition2
            // 
            this.txtPosition2.BackColor = System.Drawing.Color.Gray;
            this.txtPosition2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition2.ForeColor = System.Drawing.Color.White;
            this.txtPosition2.Location = new System.Drawing.Point(140, 31);
            this.txtPosition2.MaxLength = 1;
            this.txtPosition2.Name = "txtPosition2";
            this.txtPosition2.Size = new System.Drawing.Size(91, 92);
            this.txtPosition2.TabIndex = 1;
            this.txtPosition2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPosition3
            // 
            this.txtPosition3.BackColor = System.Drawing.Color.Gray;
            this.txtPosition3.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition3.ForeColor = System.Drawing.Color.White;
            this.txtPosition3.Location = new System.Drawing.Point(249, 31);
            this.txtPosition3.MaxLength = 1;
            this.txtPosition3.Name = "txtPosition3";
            this.txtPosition3.Size = new System.Drawing.Size(91, 92);
            this.txtPosition3.TabIndex = 2;
            this.txtPosition3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPosition4
            // 
            this.txtPosition4.BackColor = System.Drawing.Color.Gray;
            this.txtPosition4.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition4.ForeColor = System.Drawing.Color.White;
            this.txtPosition4.Location = new System.Drawing.Point(357, 31);
            this.txtPosition4.MaxLength = 1;
            this.txtPosition4.Name = "txtPosition4";
            this.txtPosition4.Size = new System.Drawing.Size(91, 92);
            this.txtPosition4.TabIndex = 3;
            this.txtPosition4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPosition5
            // 
            this.txtPosition5.BackColor = System.Drawing.Color.Gray;
            this.txtPosition5.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition5.ForeColor = System.Drawing.Color.White;
            this.txtPosition5.Location = new System.Drawing.Point(467, 31);
            this.txtPosition5.MaxLength = 1;
            this.txtPosition5.Name = "txtPosition5";
            this.txtPosition5.Size = new System.Drawing.Size(91, 92);
            this.txtPosition5.TabIndex = 4;
            this.txtPosition5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPosition5);
            this.Controls.Add(this.txtPosition4);
            this.Controls.Add(this.txtPosition3);
            this.Controls.Add(this.txtPosition2);
            this.Controls.Add(this.txtPosition1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPosition1;
        private TextBox txtPosition2;
        private TextBox txtPosition3;
        private TextBox txtPosition4;
        private TextBox txtPosition5;
    }
}