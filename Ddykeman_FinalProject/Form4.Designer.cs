namespace Ddykeman_FinalProject
{
    partial class Form4
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
            this.btnCalculateMean = new System.Windows.Forms.Button();
            this.btnCalcSem = new System.Windows.Forms.Button();
            this.btnCalcCredits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculateMean
            // 
            this.btnCalculateMean.Location = new System.Drawing.Point(12, 12);
            this.btnCalculateMean.Name = "btnCalculateMean";
            this.btnCalculateMean.Size = new System.Drawing.Size(100, 50);
            this.btnCalculateMean.TabIndex = 0;
            this.btnCalculateMean.Text = "Mean and Standard Deviation";
            this.btnCalculateMean.UseVisualStyleBackColor = true;
            this.btnCalculateMean.Click += new System.EventHandler(this.btnCalculateMean_Click);
            // 
            // btnCalcSem
            // 
            this.btnCalcSem.Location = new System.Drawing.Point(118, 12);
            this.btnCalcSem.Name = "btnCalcSem";
            this.btnCalcSem.Size = new System.Drawing.Size(100, 50);
            this.btnCalcSem.TabIndex = 1;
            this.btnCalcSem.Text = "Per Sem";
            this.btnCalcSem.UseVisualStyleBackColor = true;
            this.btnCalcSem.Click += new System.EventHandler(this.btnCalcSem_Click);
            // 
            // btnCalcCredits
            // 
            this.btnCalcCredits.Location = new System.Drawing.Point(224, 12);
            this.btnCalcCredits.Name = "btnCalcCredits";
            this.btnCalcCredits.Size = new System.Drawing.Size(100, 50);
            this.btnCalcCredits.TabIndex = 2;
            this.btnCalcCredits.Text = "Total Credits";
            this.btnCalcCredits.UseVisualStyleBackColor = true;
            this.btnCalcCredits.Click += new System.EventHandler(this.btnCalcCredits_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 72);
            this.Controls.Add(this.btnCalcCredits);
            this.Controls.Add(this.btnCalcSem);
            this.Controls.Add(this.btnCalculateMean);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateMean;
        private System.Windows.Forms.Button btnCalcSem;
        private System.Windows.Forms.Button btnCalcCredits;
    }
}