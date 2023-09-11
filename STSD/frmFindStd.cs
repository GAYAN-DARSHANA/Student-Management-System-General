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
using System.Data.Sql;

namespace STSD
{
    public partial class frmFindStd : Form
    {
        public frmFindStd()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void frmFindStd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'find_StudentBDS.fStdMaster' table. You can move, or remove it, as needed.
           // this.fStdMasterTableAdapter.Fill(this.find_StudentBDS.fStdMaster);
            // TODO: This line of code loads data into the 'find_StudentBDS.fStdMaster' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'bPSolutionDataSet2.fStdMaster1' table. You can move, or remove it, as needed.
            // this.fStdMaster1TableAdapter.Fill(this.bPSolutionDataSet2.fStdMaster1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmstudentreg IDcr = new frmstudentreg();
            IDcr.RegID = this.dataGridView_findstdmaster.CurrentRow.Cells[1].Value.ToString();
            IDcr.stdName = this.dataGridView_findstdmaster.CurrentRow.Cells[3].Value.ToString();
            IDcr.stdRegDate = this.dataGridView_findstdmaster.CurrentRow.Cells[5].Value.ToString();
            IDcr.stdRegCatg = this.dataGridView_findstdmaster.CurrentRow.Cells[2].Value.ToString();
            IDcr.ShowDialog();
        }

        private void txtsch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQL2019;Initial Catalog=BPSolution;User ID=sa;Password=data@123");
            con.ConnectionString = (@"Data Source=.\SQL2019;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            con.Open();
            //opening connection
            if (txtsch.TextLength > 0)
            {
                try
                {
                   // this.fStdMasterTableAdapter.Fill(this.find_StudentBDS.fStdMaster);
                    //initialize a new instance of sqlcommand
                    cmd = new SqlCommand();
                    //set a connection used by this instance of sqlcommand
                    cmd.Connection = con;
                    //set the sql statement to execute at the data source
                    cmd.CommandText = "SELECT RegID,RegCategory,FullName,DOB,OffRegDate,stdImage,stdQR FROM fStdMaster WHERE [RegID] LIKE N'%" + txtsch.Text + "%' OR [FullName] LIKE N'%"
                        + txtsch.Text + "%' OR [DOB] LIKE '%" + txtsch.Text + " % '  OR [DOB] LIKE '%" + " % '";

                    //initialize a new instance of sqlDataAdapter
                    da = new SqlDataAdapter();
                    //set the sql statement or stored procedure to execute at the data source
                    da.SelectCommand = cmd;
                    //initialize a new instance of DataTable
                    dt = new DataTable();
                    //add or resfresh rows in the certain range in the datatable to match those in the data source.
                    da.Fill(dt);
                    //set the data source to display the data in the datagridview
                    dataGridView_findstdmaster.DataSource = dt;

                }
                catch (Exception ex)
                {
                    //catching error 
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
