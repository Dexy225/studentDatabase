using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Security.Cryptography;
using System.IO;

namespace Ddykeman_FinalProject
{
    public partial class Form3 : Form
    {
        private int _studentId;
        private int _courseId;

        private string csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Academic Records.csv");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.academicRecordsTableAdapter.Fill(this.schoolRecordsDataSet.AcademicRecords);
            this.coursesTableAdapter.Fill(this.schoolRecordsDataSet.Courses);
            this.studentsTableAdapter.Fill(this.schoolRecordsDataSet.Students);

            LoadAcademicRecordsIntoDataGridView();
            LoadAcademicRecordsFromCsv();

            MessageBox.Show($"CSV File Path: {csvFilePath}");

        }

        private void LoadAcademicRecordsFromCsv()
        {
            if (File.Exists(csvFilePath))
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                foreach (string line in lines.Skip(1))
                {
                    string[] fields = line.Split(',');
                    Console.WriteLine($"StudentID: {fields[0]}, CourseID: {fields[1]}, CourseName: {fields[2]}, Mark: {fields[3]}");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmboBoxStudent.SelectedValue == null || cmboBoxCourse.SelectedValue == null || string.IsNullOrWhiteSpace(txtBoxMark.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                string studentID = cmboBoxStudent.SelectedValue.ToString();
                string courseID = cmboBoxCourse.SelectedValue.ToString(); 
                string courseName = cmboBoxCourse.Text;                   
                string mark = txtBoxMark.Text;

                if (!double.TryParse(mark, out _))
                {
                    MessageBox.Show("Invalid mark value. Please enter a numeric value.");
                    return;
                }

                bool fileExists = File.Exists(csvFilePath);

                using (StreamWriter writer = new StreamWriter(csvFilePath, append: true))
                {
                    if (!fileExists)
                    {
                        writer.WriteLine("StudentID,CourseID,CourseName,Mark");
                    }

                    writer.WriteLine($"{studentID},{courseID},{courseName},{mark}");
                }

                MessageBox.Show($"Record saved successfully!\n\nWritten Data:\nStudentID: {studentID}\nCourseID: {courseID}\nCourseName: {courseName}\nMark: {mark}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            LoadAcademicRecordsIntoDataGridView();
            LoadAcademicRecordsFromCsv();
        }

        private void LoadAcademicRecordsIntoDataGridView()
        {
            if (File.Exists(csvFilePath))
            {
                DataTable table = new DataTable();
                table.Columns.Add("StudentID");
                table.Columns.Add("CourseID");
                table.Columns.Add("CourseName");
                table.Columns.Add("Mark");

                string[] lines = File.ReadAllLines(csvFilePath);
                foreach (string line in lines.Skip(1)) 
                {
                    string[] fields = line.Split(',');
                    table.Rows.Add(fields);
                }

                dataGridViewRecords.DataSource = table; 
            }
            else
            {
                MessageBox.Show("No Academic Records.csv file found in the project directory.");
            }
        }
    }
}
