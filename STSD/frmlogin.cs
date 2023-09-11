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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Make the Connection with MSSQL
            SqlConnection con = new SqlConnection(@"Data Source=.\SQL2019;Initial Catalog=BPSolution;User ID=sa;Password=data@123");
            con.ConnectionString = (@"Data Source=.\SQL2019;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            con.Open();



            //Looking for the dataset - fpass
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from fpass where username='" + txt_username.Text + "' and password='" + txt_password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //If input validate 
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard ss = new Dashboard();
                ss.Show();
            }
            else
            {
                //If input not valid 
                MessageBox.Show("Please Enter the Correct Username and Password", "wrong password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_username.Text = "";
                txt_password.Text = "";

            }
        }

        private void btn_lgnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
