using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSD
{
    public partial class frmBulkIDPrint : Form
    {
        public frmBulkIDPrint()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void frmBulkIDPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bPSolutionDataSet1.fStdMaster' table. You can move, or remove it, as needed.
            this.fStdMasterTableAdapter.Fill(this.bPSolutionDataSet1.fStdMaster);
            // TODO: This line of code loads data into the 'BPSolutionDataSet2.fStdMaster1' table. You can move, or remove it, as needed.
            this.fStdMaster1TableAdapter.Fill(this.BPSolutionDataSet2.fStdMaster1);
            // TODO: This line of code loads data into the 'BPSolutionDataSet2.fStdMaster' table. You can move, or remove it, as needed.
            //this.fStdMasterTableAdapter.Fill(this.BPSolutionDataSet2.fStdMaster);
            // TODO: This line of code loads data into the 'DSID.ftempstdID' table. You can move, or remove it, as needed.
            this.ftempstdIDTableAdapter.Fill(this.DSID.ftempstdID);

            this.reportViewer1.RefreshReport();
        }

        private void btn_closefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdsvr_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQL2019;Initial Catalog=BPSolution;User ID=sa;Password=data@123");
            con.ConnectionString = (@"Data Source=.\SQL2019;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            
            //opening connection

            try
            {
                //initialize a new instance of sqlcommand
                cmd = new SqlCommand();
                //set a connection used by this instance of sqlcommand
                cmd.Connection = con;

                //copy temp data from temp table and replace in original table
                con.Open();
                cmd.CommandText = "INSERT INTO fcreatedstdID(RegNo, RegCategory, FullName, DOB, OffRegDate, stdImage, stdQR) SELECT RegNo, RegCategory, FullName, DOB, OffRegDate, stdImage, stdQR from ftempstdID";
                cmd.ExecuteNonQuery();
                con.Close();
                //set the sql statement to execute at the data source
                con.Open();
                cmd.CommandText = "Delete from ftempstdID";
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmstudentreg stdreg = new frmstudentreg();
            stdreg.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmstdSelection stdprsel = new frmstdSelection();
            stdprsel.Show();
        }
        
    }
}
