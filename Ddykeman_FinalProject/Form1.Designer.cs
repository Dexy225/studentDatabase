namespace Ddykeman_FinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.btnStudentRecords = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.Location = new System.Drawing.Point(12, 181);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(100, 50);
            this.btnStudentInfo.TabIndex = 1;
            this.btnStudentInfo.Text = "Student Info";
            this.btnStudentInfo.UseVisualStyleBackColor = true;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // btnStudentRecords
            // 
            this.btnStudentRecords.Location = new System.Drawing.Point(148, 181);
            this.btnStudentRecords.Name = "btnStudentRecords";
            this.btnStudentRecords.Size = new System.Drawing.Size(100, 50);
            this.btnStudentRecords.TabIndex = 2;
            this.btnStudentRecords.Text = "Academic Report";
            this.btnStudentRecords.UseVisualStyleBackColor = true;
            this.btnStudentRecords.Click += new System.EventHandler(this.btnStudentRecords_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(282, 181);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 50);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 247);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnStudentRecords);
            this.Controls.Add(this.btnStudentInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStudentInfo;
        private System.Windows.Forms.Button btnStudentRecords;
        private System.Windows.Forms.Button btnGenerate;
    }
}

