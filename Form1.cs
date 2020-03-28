using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace HR_To_AWS
{
    public partial class Form1 : Form
    {
        DEMO_KD_1Entities context = new DEMO_KD_1Entities();

        public Form1()
        {
            InitializeComponent();
            //Disable all buttons
            ReadBTN.Enabled = false;
            ToCSVBTN.Enabled = false;
            SendBTN.Enabled = false;
            ChartBTN.Enabled = false;

            //Hide all labels
            RunLBL.Visible = false;
            ReadLBL.Visible = false;
            ToCSVLBL.Visible = false;
            SendLBL.Visible = false;
        }

        private DataTable DT = new DataTable();



        private void RunBTN_Click(object sender, EventArgs e)
        {
            context.AWS_PRAC_TO_VECTOR();
            ReadBTN.Enabled = true;
            RunLBL.Visible = true;
        }
        private void ReadBTN_Click(object sender, EventArgs e)
        {
            /*AWS_PRAC_WEKTOR emp = context.AWS_PRAC_WEKTOR.FirstOrDefault();*/

            var emps = context.AWS_PRAC_WEKTOR.ToList();

            // Populate a new data table and bind it to the BindingSource.
            dataGridView1.DataSource = emps.ToList();

            ToCSVBTN.Enabled = true;
            ReadLBL.Visible = true;
        }

        private void ToCSVBTN_Click(object sender, EventArgs e)
        {
            StringBuilder csv_value = new StringBuilder();
            var emps = context.AWS_PRAC_WEKTOR.ToList();
            csv_value.Append("id,status,holl_days,id_prac,ill_days,work_days,year,month\n");
            foreach(var employee in emps)
            {
                csv_value.Append(employee.id);
                csv_value.Append(",");
                csv_value.Append(employee.status);
                csv_value.Append(",");
                csv_value.Append(employee.holl_days);
                csv_value.Append(",");
                csv_value.Append(employee.id_prac);
                csv_value.Append(",");
                csv_value.Append(employee.ill_days);
                csv_value.Append(",");
                csv_value.Append(employee.work_days);
                csv_value.Append(",");
                csv_value.Append(employee.year);
                csv_value.Append(",");
                csv_value.Append(employee.month);
                csv_value.Append("\n");
            }

            Stream myStream;
            SaveFileDialog saveFileDialog_csv = new SaveFileDialog();

            saveFileDialog_csv.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog_csv.RestoreDirectory = true;

            if (saveFileDialog_csv.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog_csv.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    byte[] info = new UTF8Encoding(true).GetBytes(csv_value.ToString());
                    myStream.Write(info, 0, info.Length);
                    myStream.Close();
                }
            }

            SendBTN.Enabled = true;
            ToCSVLBL.Visible = true;
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            AWSS3Utils BucketS3 = new AWSS3Utils();
            BucketS3.AsyncUpload(@"C:\Users\Kickdrew\Desktop\aaa_plik.csv");

            ChartBTN.Enabled = true;
            SendLBL.Visible = true;
        }

        private void ChartBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wwwklient.s3-eu-west-1.amazonaws.com/KUB/Witryna/witryna/index.html");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
