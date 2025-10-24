using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddykeman_FinalProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }



        private double CalculateStandardDeviation(IEnumerable<double> data)
        {
            double mean = CalculateMean(data);
            return Math.Sqrt(data.Sum(x => Math.Pow(x - mean, 2)) / (data.Count() - 1));
        }

        private double CalculateMean(IEnumerable<double> data)
        {
            return data.Average();
        }


        private DataTable LoadDataFromCsv(string filePath)
        {
            DataTable table = new DataTable();
            table.Columns.Add("StudentID", typeof(int));
            table.Columns.Add("CourseID", typeof(int));
            table.Columns.Add("CourseName", typeof(string));
            table.Columns.Add("Mark", typeof(double));

            if (!File.Exists(filePath)) return table;

            foreach (var line in File.ReadAllLines(filePath).Skip(1))
            {
                var fields = line.Split(',');
                table.Rows.Add(int.Parse(fields[0]), int.Parse(fields[1]), fields[2], double.Parse(fields[3]));
            }

            return table;
        }

        private Dictionary<int, int> GetCourseCreditsFromDatabase()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dex\\Desktop\\Coding\\Ddykeman_FinalProject\\Ddykeman_FinalProject\\SchoolRecords.mdf;Integrated Security=True";
            Dictionary<int, int> courseCredits = new Dictionary<int, int>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CourseID, Credits FROM dbo.Courses";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int courseID = reader.GetInt32(0); 
                        int credits = reader.GetInt32(1);
                        courseCredits[courseID] = credits;
                    }
                }
            }

            return courseCredits;
        }


        private string GenerateReport(string title, IEnumerable<string> content)
        {
            return $"{title}:\n\n{string.Join("\n", content)}";
        }


        int GetSemesterFromCourseID(int courseID)
        {
            if (courseID >= 1 && courseID <= 6) return 1;
            if (courseID >= 7 && courseID <= 12) return 2;
            if (courseID >= 13 && courseID <= 18) return 3;
            if (courseID >= 19 && courseID <= 23) return 4;
            if (courseID >= 24 && courseID <= 27) return 5;
            if (courseID >= 28 && courseID <= 31) return 6;
            return 0;
        }



        private void btnCalculateMean_Click(object sender, EventArgs e)
        {
            string csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Academic Records.csv");
            if (!File.Exists(csvFilePath))
            {
                MessageBox.Show("No Academic Records.csv file found.");
                return;
            }

            DataTable recordsTable = new DataTable();
            recordsTable.Columns.Add("StudentID", typeof(int));
            recordsTable.Columns.Add("CourseID", typeof(int));
            recordsTable.Columns.Add("CourseName", typeof(string));
            recordsTable.Columns.Add("Mark", typeof(double));

            foreach (string line in File.ReadAllLines(csvFilePath).Skip(1)) 
            {
                string[] fields = line.Split(',');
                recordsTable.Rows.Add(int.Parse(fields[0]), int.Parse(fields[1]), fields[2], double.Parse(fields[3]));
            }

            StringBuilder report = new StringBuilder();

            // Course
            var studentGroups = recordsTable.AsEnumerable().GroupBy(row => row.Field<int>("StudentID"));
            report.AppendLine("Student Metrics (Average and Standard Deviation):\n");

            foreach (var studentGroup in studentGroups)
            {
                int studentID = studentGroup.Key;
                var marks = studentGroup.Select(row => row.Field<double>("Mark"));

                double mean = CalculateMean(marks);
                double stdDev = CalculateStandardDeviation(marks);

                report.AppendLine($"StudentID: {studentID}");
                report.AppendLine($"- Average: {mean:F2}");
                report.AppendLine($"- Standard Deviation: {stdDev:F2}");
                report.AppendLine();
            }

            var courseGroups = recordsTable.AsEnumerable().GroupBy(row => row.Field<int>("CourseID"));
            report.AppendLine("Course Metrics:\n");

            foreach (var courseGroup in courseGroups)
            {
                int courseID = courseGroup.Key;
                var marks = courseGroup.Select(row => row.Field<double>("Mark"));

                double mean = marks.Average();

                double stdDev = Math.Sqrt(marks.Sum(mark => Math.Pow(mark - mean, 2)) / (marks.Count() - 1));

                report.AppendLine($"CourseID: {courseID}");
                report.AppendLine($"- Mean: {mean:F2}");
                report.AppendLine($"- Standard Deviation: {stdDev:F2}");
                report.AppendLine();
            }

            MessageBox.Show(report.ToString(), "Metrics Report");
        }



        private void btnCalcSem_Click(object sender, EventArgs e)
        {
            var records = LoadDataFromCsv(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Academic Records.csv"));
            var studentGroups = records.AsEnumerable().GroupBy(r => r.Field<int>("StudentID"));

            var report = studentGroups.Select(group =>
            {
                var semesterAverages = Enumerable.Range(1, 6)
                    .Select(semester =>
                    {
                        var semesterMarks = group
                            .Where(r => GetSemesterFromCourseID(r.Field<int>("CourseID")) == semester)
                            .Select(r => r.Field<double>("Mark"));
                        return $"  Semester {semester}: {semesterMarks.DefaultIfEmpty(0).Average():F2}";
                    });

                return $"StudentID: {group.Key}\n{string.Join("\n", semesterAverages)}\n";
            });

            MessageBox.Show(GenerateReport("Student Semester Averages", report), "Report");
        }


        private void btnCalcCredits_Click(object sender, EventArgs e)
        {
            var records = LoadDataFromCsv(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Academic Records.csv"));
            var studentGroups = records.AsEnumerable().GroupBy(r => r.Field<int>("StudentID"));
            var courseCredits = GetCourseCreditsFromDatabase(); 

            var report = studentGroups.Select(group =>
            {
                int totalCredits = group
                    .Where(r => r.Field<double>("Mark") >= 50)
                    .Sum(r => courseCredits.ContainsKey(r.Field<int>("CourseID")) ? courseCredits[r.Field<int>("CourseID")] : 0);

                return $"StudentID: {group.Key} - Total Credits Passed: {totalCredits}";
            });

            MessageBox.Show(GenerateReport("Total Credits Passed", report), "Report");
        }
    }
}
