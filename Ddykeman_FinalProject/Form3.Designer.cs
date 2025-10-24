namespace Ddykeman_FinalProject
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label markLabel;
            this.cmboBoxStudent = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolRecordsDataSet = new Ddykeman_FinalProject.SchoolRecordsDataSet();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmboBoxCourse = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentsTableAdapter = new Ddykeman_FinalProject.SchoolRecordsDataSetTableAdapters.StudentsTableAdapter();
            this.coursesTableAdapter = new Ddykeman_FinalProject.SchoolRecordsDataSetTableAdapters.CoursesTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.academicRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicRecordsTableAdapter = new Ddykeman_FinalProject.SchoolRecordsDataSetTableAdapters.AcademicRecordsTableAdapter();
            this.tableAdapterManager = new Ddykeman_FinalProject.SchoolRecordsDataSetTableAdapters.TableAdapterManager();
            this.txtBoxMark = new System.Windows.Forms.TextBox();
            this.fKAcademicRecordsToStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            markLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolRecordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAcademicRecordsToStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Location = new System.Drawing.Point(69, 84);
            markLabel.Name = "markLabel";
            markLabel.Size = new System.Drawing.Size(34, 13);
            markLabel.TabIndex = 6;
            markLabel.Text = "Mark:";
            // 
            // cmboBoxStudent
            // 
            this.cmboBoxStudent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentsBindingSource2, "StudentID", true));
            this.cmboBoxStudent.DataSource = this.studentsBindingSource1;
            this.cmboBoxStudent.DisplayMember = "FirstName";
            this.cmboBoxStudent.FormattingEnabled = true;
            this.cmboBoxStudent.Location = new System.Drawing.Point(109, 11);
            this.cmboBoxStudent.Name = "cmboBoxStudent";
            this.cmboBoxStudent.Size = new System.Drawing.Size(121, 21);
            this.cmboBoxStudent.TabIndex = 0;
            this.cmboBoxStudent.ValueMember = "StudentID";
            // 
            // studentsBindingSource2
            // 
            this.studentsBindingSource2.DataMember = "Students";
            this.studentsBindingSource2.DataSource = this.schoolRecordsDataSet;
            // 
            // schoolRecordsDataSet
            // 
            this.schoolRecordsDataSet.DataSetName = "SchoolRecordsDataSet";
            this.schoolRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.schoolRecordsDataSet;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.schoolRecordsDataSet;
            // 
            // cmboBoxCourse
            // 
            this.cmboBoxCourse.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "Semester", true));
            this.cmboBoxCourse.DataSource = this.coursesBindingSource1;
            this.cmboBoxCourse.DisplayMember = "CourseName";
            this.cmboBoxCourse.FormattingEnabled = true;
            this.cmboBoxCourse.Location = new System.Drawing.Point(109, 45);
            this.cmboBoxCourse.Name = "cmboBoxCourse";
            this.cmboBoxCourse.Size = new System.Drawing.Size(121, 21);
            this.cmboBoxCourse.TabIndex = 1;
            this.cmboBoxCourse.ValueMember = "CourseID";
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.schoolRecordsDataSet;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.schoolRecordsDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Course";
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // academicRecordsBindingSource
            // 
            this.academicRecordsBindingSource.DataMember = "AcademicRecords";
            this.academicRecordsBindingSource.DataSource = this.schoolRecordsDataSet;
            // 
            // academicRecordsTableAdapter
            // 
            this.academicRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcademicRecordsTableAdapter = this.academicRecordsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ddykeman_FinalProject.SchoolRecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtBoxMark
            // 
            this.txtBoxMark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicRecordsBindingSource, "Mark", true));
            this.txtBoxMark.Location = new System.Drawing.Point(109, 81);
            this.txtBoxMark.Name = "txtBoxMark";
            this.txtBoxMark.Size = new System.Drawing.Size(121, 20);
            this.txtBoxMark.TabIndex = 7;
            // 
            // fKAcademicRecordsToStudentsBindingSource
            // 
            this.fKAcademicRecordsToStudentsBindingSource.DataMember = "FK_AcademicRecords_ToStudents";
            this.fKAcademicRecordsToStudentsBindingSource.DataSource = this.studentsBindingSource;
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Location = new System.Drawing.Point(307, 11);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.Size = new System.Drawing.Size(475, 150);
            this.dataGridViewRecords.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 177);
            this.Controls.Add(this.dataGridViewRecords);
            this.Controls.Add(markLabel);
            this.Controls.Add(this.txtBoxMark);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboBoxCourse);
            this.Controls.Add(this.cmboBoxStudent);
            this.Name = "Form3";
            this.Text = "Academic Report";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolRecordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAcademicRecordsToStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboBoxStudent;
        private System.Windows.Forms.ComboBox cmboBoxCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SchoolRecordsDataSet schoolRecordsDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private SchoolRecordsDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private SchoolRecordsDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource academicRecordsBindingSource;
        private SchoolRecordsDataSetTableAdapters.AcademicRecordsTableAdapter academicRecordsTableAdapter;
        private SchoolRecordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtBoxMark;
        private System.Windows.Forms.BindingSource studentsBindingSource2;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.BindingSource fKAcademicRecordsToStudentsBindingSource;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
    }
}