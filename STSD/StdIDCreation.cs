using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;
using Microsoft.Reporting.WinForms;

namespace STSD
{
    public partial class StdIDCreation : Form
    {
        public StdIDCreation()
        {
            InitializeComponent();
        }

        private void StdIDCreation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSID.ftempstdID' table. You can move, or remove it, as needed.
            this.ftempstdIDTableAdapter.Fill(this.DSID.ftempstdID);
            //StdIDCreation dsCustomers =new  GetData();
            // ReportDataSource datasource = new ReportDataSource("Customers", dsCustomers.Tables[0]);
            // this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(datasource);
            // this.reportViewer1.RefreshReport();


            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ImageFileName = "C:\\Users\\gayan\\Documents\\Adobe";
            GeneratedBarcode Qrcode = QRCodeWriter.CreateQrCode(stdID.Text);
            Qrcode.SaveAsPng("QrCode.png");

            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                // store image file path in class data member. Initialize it as string ImageFileName;
                ImageFileName = open.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    encoder.QRCodeScale = 3;
                    Bitmap bmp = encoder.Encode("Student ID: " + stdID.Text + " Registered Category - " + stdRegCatg.Text +" Student Full Name - " + stdName.Text );
                    pictureBox1.Image = bmp;
                    bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                }
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox2.Image = barcode.Draw(stdID.Text, 50);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_closefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}

