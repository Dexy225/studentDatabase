using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddykeman_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void btnStudentRecords_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();
        }

    }
}
