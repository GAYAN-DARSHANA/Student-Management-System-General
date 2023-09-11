using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSD
{
    public partial class frmstdRegEx : Form
    {
        public string stdRegNo { get; set; }
        public string stdName { get; set; }
        public string stdDOB { get; set; }
        public string stdScl { get; set; }
        public string stdSclGrade { get; set; }
        public string stdRegDate { get; set; }
        public string stdGardName { get; set; }
        public string stdAddress { get; set; }
        public string stdTele { get; set; }
        public string attGrade { get; set; }
        public string attDate { get; set; }
        public string stdJoinCat { get; set; }
        public string stdPreDhmScl { get; set; }
        public string stdPreDhmSclResg { get; set; }


        public frmstdRegEx()
        {
            InitializeComponent();
        }

        private void frmstdRegEx_Load(object sender, EventArgs e)
        {
            textBox1.Text = stdRegNo;
            textBox2.Text = stdName;
            textBox3.Text = stdDOB;
            textBox4.Text = stdScl;
            textBox5.Text = stdSclGrade;
            textBox6.Text = stdRegDate;
            textBox7.Text = stdGardName;
            textBox8.Text = stdAddress;
            textBox9.Text = stdTele;
            textBox10.Text = attGrade;
            textBox11.Text = attDate;
            textBox12.Text = stdJoinCat;
            textBox13.Text = stdPreDhmScl;
            textBox14.Text = stdPreDhmSclResg;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportParameterCollection parms = new ReportParameterCollection();
            parms.Add(new ReportParameter("stdRegNo", textBox1.Text));
            parms.Add(new ReportParameter("stdName", textBox2.Text));
            parms.Add(new ReportParameter("stdDOB", textBox3.Text));
            parms.Add(new ReportParameter("stdScl", textBox4.Text));
            parms.Add(new ReportParameter("stdSclGrade", textBox5.Text));
            parms.Add(new ReportParameter("stdRegDate", textBox6.Text));
            parms.Add(new ReportParameter("stdGardName", textBox7.Text));
            parms.Add(new ReportParameter("stdAddress", textBox8.Text));
            parms.Add(new ReportParameter("stdTele", textBox9.Text));
            parms.Add(new ReportParameter("attGrade", textBox10.Text));
            parms.Add(new ReportParameter("attDate", textBox11.Text));
            //parms.Add(new ReportParameter("stdJoinCat", textBox12.Text));
            parms.Add(new ReportParameter("stdPreDhmScl", textBox13.Text));
            parms.Add(new ReportParameter("stdPreDhmSclResg", textBox14.Text));

            reportViewer1.LocalReport.SetParameters(parms);
            this.reportViewer1.RefreshReport();
        }
    }
}
