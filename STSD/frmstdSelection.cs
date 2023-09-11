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
using System.Configuration;


namespace STSD
{

    public partial class frmstdSelection : Form
    {
        public frmstdSelection()
        {
            InitializeComponent(); 
            //initialize all classes
          
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private void frmstdSelection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'selection_std.fStdMaster' table. You can move, or remove it, as needed.
            //this.fStdMasterTableAdapter2.Fill(this.selection_std.fStdMaster);
            // TODO: This line of code loads data into the 'fstdreg.fStdMaster' table. You can move, or remove it, as needed.
            this.fStdMasterTableAdapter1.Fill(this.fstdreg.fStdMaster);
            // TODO: This line of code loads data into the 'stdSelection_grid_print.ftempstdID' table. You can move, or remove it, as needed.
            this.ftempstdIDTableAdapter1.Fill(this.stdSelection_grid_print.ftempstdID);
            // TODO: This line of code loads data into the 'bPSolutionDataSet2.fStdMaster1' table. You can move, or remove it, as needed.
            this.fStdMaster1TableAdapter.Fill(this.bPSolutionDataSet2.fStdMaster1);
            // TODO: This line of code loads data into the 'dSID.ftempstdID' table. You can move, or remove it, as needed.
            this.ftempstdIDTableAdapter.Fill(this.dSID.ftempstdID);
            dataGridView2.Refresh();
            // TODO: This line of code loads data into the 'dSID.ftempstdID1' table. You can move, or remove it, as needed.
            //  this.ftempstdID1TableAdapter.Fill(this.dSID.ftempstdID1);

            // TODO: This line of code loads data into the 'dSID.ftempstdID1' table. You can move, or remove it, as needed.
            // this.ftempstdID1TableAdapter.Fill(this.dSID.ftempstdID1);
            // TODO: This line of code loads data into the 'studentSelectionID.fStdMaster' table. You can move, or remove it, as needed.
            this.fStdMasterTableAdapter.Fill(this.studentSelectionID.fStdMaster);
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, chkbox);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StdIDCreation IDcr = new StdIDCreation();
            IDcr.stdID.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            IDcr.stdName.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            IDcr.stdRegDate.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            IDcr.stdRegCatg.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            IDcr.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  //validation

            SqlConnection con = new SqlConnection(@"Data Source=.\SQL2019;Initial Catalog=BPSolution;User ID=sa;Password=data@123");
            con.ConnectionString = (@"Data Source=.\SQL2019;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            con.Open();
            
            DataTable dt;
            string sql;

            DateTime dateToday = dateTimePicker1.Value;

            string strDate = dateToday.ToString("yyyy-MM-dd");

            sql = "SELECT * FROM 'fStdMaster' WHERE DOB = '" + strDate + "'";
            
            // dataGridViewBindingSource.Filter = string.Format("Paid_Date = '{0}'", dateTimePicker1.Value.ToShortDateString());
          */
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
                    //initialize a new instance of sqlcommand
                    cmd = new SqlCommand();
                    //set a connection used by this instance of sqlcommand
                    cmd.Connection = con;
                    //set the sql statement to execute at the data source
                    cmd.CommandText = "SELECT RegID,RegCategory,FullName,DOB,OffRegDate,stdImage,stdQR FROM fStdMaster WHERE [RegID] LIKE N'%" + txtsch.Text + "%' OR [FullName] LIKE N'%" 
                        + txtsch.Text + "%' OR [DOB] LIKE '%" + txtsch.Text + " % '  OR [DOB] LIKE '%" + dateTimePicker1.Value.ToString("yyyy'/'MM'/'dd") + " % '";
          
                    //initialize a new instance of sqlDataAdapter
                    da = new SqlDataAdapter();
                    //set the sql statement or stored procedure to execute at the data source
                    da.SelectCommand = cmd;
                    //initialize a new instance of DataTable
                    dt = new DataTable();
                    //add or resfresh rows in the certain range in the datatable to match those in the data source.
                    da.Fill(dt);
                    //set the data source to display the data in the datagridview
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    //catching error 
                    MessageBox.Show(ex.Message);
                }
            }
            

            //release all resources used by the component
            da.Dispose();
            //dr.Close();
            //clossing connection
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQL2019;Initial Catalog=BPSolution;User ID=sa;Password=data@123");
            con.ConnectionString = (@"Data Source=.\SQL2019;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Autorec,RegCategory,RegID,FullName,DOB,ContactNo,Address,OffRegDate ,Remarks  from fStdMaster where [DOB] LIKE '%" + dateTimePicker1.Value + "%'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.ftempstdID1TableAdapter.FillBy(this.dSID.ftempstdID1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnIDGsel_Click(object sender, EventArgs e)
        {
            //transferdataOrg();


           try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["STSD.Properties.Settings.BPSolutionConnectionString"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                    if (chkboxselected)
                    {
                        string sqlquery = "Insert into [dbo].[ftempstdID] values (@RegNo, @RegCategory, @FullName, @DOB, @offRegDate, @stdImage, @stdQR)";
                        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                        sqlcomm.Parameters.AddWithValue("@RegNo", dr.Cells[1].Value);
                        sqlcomm.Parameters.AddWithValue("@RegCategory", dr.Cells[2].Value);
                        sqlcomm.Parameters.AddWithValue("@FullName", dr.Cells[3].Value);
                        sqlcomm.Parameters.AddWithValue("@DOB", dr.Cells[4].Value);
                        sqlcomm.Parameters.AddWithValue("@offRegDate", dr.Cells[5].Value);
                        sqlcomm.Parameters.AddWithValue("@stdImage", dr.Cells[6].Value);
                        sqlcomm.Parameters.AddWithValue("@stdQR", dr.Cells[7].Value);
                        sqlconn.Open();
                        sqlcomm.ExecuteNonQuery();
                        disp_Data();
                        sqlconn.Close();
                    }
                }
            }
            
           catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
        private void disp_Data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=GAYAN-LAPTOP\SQLEXPRESS;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            con.ConnectionString = (@"Data Source=.\SQL2019;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select*From ftempstdID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void btn_Print1_Click(object sender, EventArgs e)
        {
            frmBulkIDPrint Idbp = new frmBulkIDPrint();
            this.Close();
            Idbp.Show();
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.ftempstdIDTableAdapter.FillBy(this.dSID.ftempstdID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ftempstdIDTableAdapter.FillBy1(this.dSID.ftempstdID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
       
    }
    }

