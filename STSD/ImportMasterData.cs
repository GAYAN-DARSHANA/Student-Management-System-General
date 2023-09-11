using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;

namespace STSD
{
    public partial class ImportMasterData : Form
    {
        public ImportMasterData()
        {
            InitializeComponent();
        }

        private void ImportMasterData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fstdreg.fStdMaster' table. You can move, or remove it, as needed.
           // this.fStdMasterTableAdapter.Fill(this.fstdreg.fStdMaster);

        }
        //DataTableCollection tables;
        private void btnbrw_Click(object sender, EventArgs e)
        {
            ofdSelect.ShowDialog();
        }
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private void ofdSelectOk(object sender, CancelEventArgs e)
        {
            string filePath = ofdSelect.FileName;
            string extension = Path.GetExtension(filePath);
            string conString = "STSD.Properties.Settings.BPSolutionConnectionString";
            string sheetName = "Students";
            switch (extension)
            {
                case ".xls":
                    conString = string.Format(Excel03ConString, filePath, "YES");
                    break;
                case ".xlsx":
                    conString = string.Format(Excel07ConString, filePath, "YES");
                    break;
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dt.Rows[0]["fStdMaster"].ToString();
                    con.Close();
                }
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    OleDbDataAdapter oda = new OleDbDataAdapter();
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    oda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    con.Close();
                    dgvStudent.DataSource = dt;
                }
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[21] {
                new DataColumn("Autorec", typeof(int)),
                new DataColumn("RegID", typeof(string)),
                new DataColumn("RegCategory", typeof(string)),
                new DataColumn("FullName", typeof(string)),
                new DataColumn("Address", typeof(string)),
                new DataColumn("DOB", typeof(string)),
                new DataColumn("ContactNo", typeof(string)),
                new DataColumn("Guardian", typeof(string)),
                new DataColumn("NameSchool", typeof(string)),
                new DataColumn("SclGrade", typeof(string)),
                new DataColumn("PreDahamScl", typeof(string)),
                new DataColumn("OffGradeAtt", typeof(string)),
                new DataColumn("OffRegDate", typeof(string)),
                new DataColumn("Remarks", typeof(string)),
                new DataColumn("StdStatus_Active", typeof(string)),
                new DataColumn("StdStatus_Resign", typeof(string)),
                new DataColumn("StdStatus_Susp", typeof(string)),
                new DataColumn("StdStatus_Dism", typeof(string)),
                new DataColumn("AddDate", typeof(string)),
                new DataColumn("stdImage", typeof(string)),
                new DataColumn("stdQR", typeof(string))


                });
                foreach (DataGridViewRow row in dgvStudent.Rows)
                {
                    int Autorec = Convert.ToInt32(row.Cells[0].Value);
                    string RegID = row.Cells[1].Value.ToString();
                    string RegCategory = row.Cells[2].Value.ToString();
                    string FullName = row.Cells[3].Value.ToString();
                    string Address = row.Cells[4].Value.ToString();
                    string DOB = row.Cells[5].Value.ToString();
                    string ContactNo = row.Cells[6].Value.ToString();
                    string Guardian = row.Cells[7].Value.ToString();
                    string NameSchool = row.Cells[8].Value.ToString();
                    string SclGrade = row.Cells[9].Value.ToString();
                    string PreDahamScl = row.Cells[10].Value.ToString();
                    string OffGradeAtt = row.Cells[11].Value.ToString();
                    string OffRegDate = row.Cells[12].Value.ToString();
                    string Remarks = row.Cells[13].Value.ToString();
                    string StdStatus_Active = row.Cells[14].Value.ToString();
                    string StdStatus_Resign = row.Cells[15].Value.ToString();
                    string StdStatus_Susp = row.Cells[16].Value.ToString();
                    string StdStatus_Dism = row.Cells[17].Value.ToString();
                    string AddDate = row.Cells[18].Value.ToString();
                    string stdImage = row.Cells[19].Value.ToString();
                    string stdQR = row.Cells[20].Value.ToString();


                    dt.Rows.Add(Autorec, FullName, OffGradeAtt);
                }
                if (dt.Rows.Count > 0)
                {
                    string str = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            sqlBulkCopy.DestinationTableName = "dbo.Customers";
                            sqlBulkCopy.ColumnMappings.Add("Autorec", "Autorec");
                            sqlBulkCopy.ColumnMappings.Add("RegID", "RegID");
                            sqlBulkCopy.ColumnMappings.Add("RegCategory", "RegCategory");
                            sqlBulkCopy.ColumnMappings.Add("FullName", "FullName");
                            sqlBulkCopy.ColumnMappings.Add("Address", "Address");
                            sqlBulkCopy.ColumnMappings.Add("DOB", "DOB");
                            sqlBulkCopy.ColumnMappings.Add("ContactNo", "ContactNo");
                            sqlBulkCopy.ColumnMappings.Add("Guardian", "Guardian");
                            sqlBulkCopy.ColumnMappings.Add("NameSchool", "NameSchool");
                            sqlBulkCopy.ColumnMappings.Add("SclGrade", "SclGrade");
                            sqlBulkCopy.ColumnMappings.Add("PreDahamScl", "PreDahamScl");
                            sqlBulkCopy.ColumnMappings.Add("OffGradeAtt", "OffGradeAtt");
                            sqlBulkCopy.ColumnMappings.Add("OffRegDate", "OffRegDate");
                            sqlBulkCopy.ColumnMappings.Add("Remarks", "Remarks");
                            sqlBulkCopy.ColumnMappings.Add("StdStatus_Active", "StdStatus_Active");
                            sqlBulkCopy.ColumnMappings.Add("StdStatus_Resign", "StdStatus_Resign");
                            sqlBulkCopy.ColumnMappings.Add("StdStatus_Susp", "StdStatus_Susp");
                            sqlBulkCopy.ColumnMappings.Add("StdStatus_Dism", "StdStatus_Dism");
                            sqlBulkCopy.ColumnMappings.Add("AddDate", "AddDate");
                            sqlBulkCopy.ColumnMappings.Add("stdImage", "stdImage");
                            sqlBulkCopy.ColumnMappings.Add("stdQR", "stdQR");
                            
                            con.Open();
                            sqlBulkCopy.WriteToServer(dt);
                            con.Close();
                        }
                    }
                }
            }
        }
    }
}

