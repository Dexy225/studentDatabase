using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddykeman_FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolRecordsDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolRecordsDataSet.AcademicRecords' table. You can move, or remove it, as needed.
            this.academicRecordsTableAdapter.Fill(this.schoolRecordsDataSet.AcademicRecords);
            // TODO: This line of code loads data into the 'schoolRecordsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.schoolRecordsDataSet.Students);

        }
    }
}
