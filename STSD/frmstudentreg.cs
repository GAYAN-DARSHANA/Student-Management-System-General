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
using System.IO;
using System.Drawing.Imaging;

namespace STSD
{

    public partial class frmstudentreg : Form
    {
        //photo path
        String ImageUrl = null;

        //private string stdName;
        SqlCommand cmd;
        int rno = 0;
        MemoryStream ms;

        public object RegID { get; internal set; }
        public string stdName { get; internal set; }
        public object stdRegDate { get; internal set; }
        public object stdRegCatg { get; internal set; }

        //byte[] photo_aray;
        public frmstudentreg()
        {
            InitializeComponent();

            //Disabled - Personal Details - Load Form
            txt_stdregno.Enabled = false;
            txt_name.Enabled = false;
            txt_address.Enabled = false;
            dtp_DOB.Enabled = false;
            txt_mobile.Enabled = false;
            //Disabled - School Details - Load Form
            txt_school.Enabled = false;
            cmb_grade.Enabled = false;
            //Disabled - Daham School Details - Load Form
            txt_pre_dhmscl.Enabled = false;
            txt_regReason.Enabled = false;
            //Disabled - Official  Details - Load Form
            dtp_registered.Enabled = false;
            cmb_gradeatt.Enabled = false;
            //Disabled - Remark  Details - Load Form
            txt_remark.Enabled = false;
            //Disabled - Uploads  Details - Load Form
            txt_imgpath.Enabled = false;
            btn_imgsearch.Enabled = false;
            btn_save.Enabled = false;
            //Disabled - Radio  selection - Load Form
            rb_existingreg.Enabled = false;
            rb_newlyreg.Enabled = false;
            //Disabled - Status  selection - Load Form
            chk_active.Enabled = false;
            chk_dimiss.Enabled = false;
            chk_resign.Enabled = false;
            chk_suspend.Enabled = false;
            //Removed----------- dtp_resigne_date.Enabled = false;
            btn_Print1.Enabled = false;
            btn_print.Enabled = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_resign.Checked == true)
            {
                MessageBox.Show("Please Disable Resign Status", "Worng Status Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chk_active.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_active.Checked == true)
            {
                MessageBox.Show("Please Disable Active Status", "Worng Status Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chk_resign.Checked = false;
            }
        }

        private void btn_save_Click (object sender, EventArgs e)
        {
            if (txt_stdregno.Text != "")
            {
                //Generating QR method***********************************
                qrgen();
            }
            SqlConnection con = new SqlConnection(@"Data Source=.\SQL2019;Initial Catalog=BPSolution;User ID=sa;Password=data@123");
            con.ConnectionString = (@"Data Source=.\SQL2019;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            con.Open();

            if (txt_stdregno.Text != "" && txt_name.Text != "" && txt_address.Text != "")
            {
               
                //Refresh();

                //Row Count*********************************************
                int count = dgv_1.RowCount;
                txt_Autorec.Text = count.ToString();
                SqlCommand cmd = new SqlCommand("INSERT INTO fStdMaster(Autorec,  RegID, RegCategory, FullName, Address, DOB, ContactNo, Guardian, NameSchool, SclGrade, PreDahamScl, OffGradeAtt, OffRegDate, Remarks, StdStatus_Active, StdStatus_Resign, StdStatus_Susp, StdStatus_Dism,  AddDate, stdImage, stdQR) VALUES(@Autorec,  @RegID, @RegCategory, @FullName, @Address, @DOB, @ContactNo, @Guardian, @NameSchool, @SclGrade, @PreDahamScl, @OffGradeAtt, @OffRegDate, @Remarks, @StdStatus_Active, @StdStatus_Resign, @StdStatus_Susp, @StdStatus_Dism,  @AddDate, @stdImage, @stdQR)", con);

                

                //Radio Button
                if (rb_existingreg.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@RegCategory", "ES");
                }
                if (rb_newlyreg.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@RegCategory", "NS");
                }

                cmd.Parameters.Add("@Autorec", txt_Autorec.Text);
                cmd.Parameters.Add("@RegID", txt_stdregno.Text);
                cmd.Parameters.Add("@FullName", txt_name.Text);
                cmd.Parameters.Add("@Address", txt_address.Text);
                cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = dtp_DOB.Value;
                cmd.Parameters.Add("@ContactNo", txt_mobile.Text);
                cmd.Parameters.Add("@Guardian", txt_gard.Text);
                cmd.Parameters.Add("@NameSchool", txt_school.Text);
                cmd.Parameters.Add("@SclGrade", cmb_grade.SelectedItem.ToString());

                // cmd.Parameters.Add("@StdRegDate", SqlDbType.DateTime).Value = dtp_regisDate.Value;   -------------- Removed

                cmd.Parameters.Add("@PreDahamScl", txt_pre_dhmscl.Text);
                cmd.Parameters.Add("@OffGradeAtt", cmb_gradeatt.SelectedItem.ToString());
                cmd.Parameters.Add("@OffRegDate", SqlDbType.DateTime).Value = dtp_registered.Value;
                cmd.Parameters.Add("@Remarks", txt_remark.Text);
                //Removed -------    cmd.Parameters.Add("@StdResignDate", SqlDbType.DateTime).Value = dtp_resigne_date.Value;
                cmd.Parameters.Add("@AddDate", SqlDbType.DateTime).Value = DateTime.Now;

                if (chk_active.Checked && chk_resign.Checked && chk_suspend.Checked && chk_dimiss.Checked)
                {
                    MessageBox.Show("Please Select Only single option  !", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    //Checkbox values****************************************
                    cmd.Parameters.AddWithValue("@StdStatus_Active", chk_active.Checked);
                    cmd.Parameters.AddWithValue("@StdStatus_Resign", chk_resign.Checked);
                    cmd.Parameters.AddWithValue("@StdStatus_Susp", chk_suspend.Checked);
                    cmd.Parameters.AddWithValue("@StdStatus_Dism", chk_dimiss.Checked);

                }

                //Insert Student Image******************************************
                Image img = pic_std.Image;
                byte[] arr;
                ImageConverter convertor = new ImageConverter();
                arr = (byte[])convertor.ConvertTo(img, typeof(byte[]));

                cmd.Parameters.AddWithValue("@stdImage", arr);

                //Insert Student QR Image******************************************
                Image imgqr = stdQR.Image;
                byte[] arrqr;
                ImageConverter convertorqr = new ImageConverter();
                arrqr = (byte[])convertorqr.ConvertTo(imgqr, typeof(byte[]));

                cmd.Parameters.AddWithValue("@stdQR", arrqr);

                cmd.ExecuteNonQuery();
                disp_Data();

                MessageBox.Show("Added Student Detials Successfully !", "Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Please Fill the Required Field  !", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void conv_photo()
        {
            //converting photo to binary data


            //using FileStream:(will not work while updating, if image is not changed)
            //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            //byte[] photo_aray = new byte[fs.Length];
            //fs.Read(photo_aray, 0, photo_aray.Length);

            /*  //using MemoryStream:
              ms = new MemoryStream();
              pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
              byte[] photo_aray = new byte[ms.Length];
              ms.Position = 0;
              ms.Read(photo_aray, 0, photo_aray.Length);
              cmd.Parameters.AddWithValue("@stdImage", photo_aray);*/

        }
        private void disp_Data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQL2019;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            con.ConnectionString = (@"Data Source=.\SQL2019;Initial Catalog=BPSolution;Persist Security Info=True;User ID=sa;Password=data@123");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select*From fStdMaster";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_1.DataSource = dt;

            con.Close();
        }

        private void qrgen()
        {
            
            {
                MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                encoder.QRCodeScale = 3;
                Bitmap bmp = encoder.Encode(txt_stdregno.Text );
                stdQR.Image = bmp;
               
            }
        }

        private void rb_newlyreg_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btn_newrec_Click(object sender, EventArgs e)
        {

            //Disabled - Personal Details - Load Form
            txt_stdregno.Enabled = true;
            txt_name.Enabled = true;
            txt_address.Enabled = true;
            dtp_DOB.Enabled = true;
            txt_mobile.Enabled = true;
            //Disabled - School Details - Load Form
            txt_school.Enabled = true;
            cmb_grade.Enabled = true;
            //Disabled - Daham School Details - Load Form
            txt_pre_dhmscl.Enabled = true;
            txt_regReason.Enabled = true;
            //Disabled - Official  Details - Load Form
            dtp_registered.Enabled = true;
            cmb_gradeatt.Enabled = true;
            //Disabled - Remark  Details - Load Form
            txt_remark.Enabled = true;
            //Disabled - Uploads  Details - Load Form
            txt_imgpath.Enabled = true;
            btn_imgsearch.Enabled = true;
            btn_save.Enabled = true;
            btn_newrec.Enabled = false;
            btn_nextrec.Enabled = false;
            btn_prevrec.Enabled = false;
            btn_closefrm.Enabled = true;
            //Disabled - Radio  selection - Load Form
            rb_existingreg.Enabled = true;
            rb_newlyreg.Enabled = true;
            //Disabled - Status  selection - Load Form
            chk_active.Enabled = true;
            chk_dimiss.Enabled = true;
            chk_resign.Enabled = true;
            chk_suspend.Enabled = true;
            //Removed------- dtp_resigne_date.Enabled = true;

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.stdRegNo = txt_stdregno.Text;
            frm1.stdName = txt_name.Text;
            frm1.stdDOB = dtp_DOB.Text;
            frm1.stdScl = txt_school.Text;
            frm1.stdSclGrade = cmb_grade.Text;
            frm1.stdRegDate = dtp_registered.Text;
            frm1.stdGardName = txt_gard.Text;
            frm1.stdAddress = txt_address.Text;
            frm1.stdTele = txt_mobile.Text;
            frm1.attGrade = cmb_gradeatt.Text;
            frm1.attDate = dtp_registered.Text;
            frm1.stdJoinCat = rb_newlyreg.Text;

            frm1.Show();


        }

        private void frmstudentreg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fstdreg.fStdMaster' table. You can move, or remove it, as needed.
            //this.fStdMasterTableAdapter1.Fill(this.fstdreg.fStdMaster);
            // TODO: This line of code loads data into the 'bPSolutionDataSet2.fStdMaster1' table. You can move, or remove it, as needed.
           // this.fStdMaster1TableAdapter.Fill(this.bPSolutionDataSet2.fStdMaster1);
            // disp_Data();

            // TODO: This line of code loads data into the 'bPSolutionDataSet1.fStdMaster' table. You can move, or remove it, as needed.
            //this.fStdMasterTableAdapter.Fill(this.bPSolutionDataSet1.fStdMaster);

        }

        private void rb_existingreg_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_existingreg.Checked == true)
            {
                // cmb_grade.Enabled = false;
                txt_pre_dhmscl.ReadOnly = false;
                txt_regReason.ReadOnly = false;
                btn_Print1.Enabled = true;
                btn_Print1.Visible = true;
                btn_print.Visible = false;

            }
        }

        private void rb_newlyreg_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rb_newlyreg.Checked == true)
            {
                // cmb_grade.Enabled = true;
                txt_pre_dhmscl.ReadOnly = true;
                txt_regReason.ReadOnly = true;
                btn_print.Visible = true;
                btn_Print1.Visible = false;
                btn_print.Enabled = true;

            }
        }

        private void btn_Print1_Click(object sender, EventArgs e)
        {
            frmstdRegEx frm1 = new frmstdRegEx();
            frm1.stdRegNo = txt_stdregno.Text;
            frm1.stdName = txt_name.Text;
            frm1.stdDOB = dtp_DOB.Text;
            frm1.stdScl = txt_school.Text;
            frm1.stdSclGrade = cmb_grade.Text;
            frm1.stdRegDate = dtp_registered.Text;
            frm1.stdGardName = txt_gard.Text;
            frm1.stdAddress = txt_address.Text;
            frm1.stdTele = txt_mobile.Text;
            frm1.attGrade = cmb_gradeatt.Text;
            frm1.attDate = dtp_registered.Text;
            frm1.stdJoinCat = rb_existingreg.Text;
            frm1.stdPreDhmScl = txt_pre_dhmscl.Text;
            frm1.stdPreDhmSclResg = txt_regReason.Text;

            frm1.Show();
        }

        private void btn_imgsearch_Click(object sender, EventArgs e)
        {
            // string ImageFileName = "C:\\Users\\gayan\\Documents\\Adobe";

            // open file dialog
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageUrl = ofd.FileName;
                    pic_std.Image = Image.FromFile(ofd.FileName);
                }

            }
        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            frmFindStd fstd = new frmFindStd();
            fstd.Show();
        }
    }
}

