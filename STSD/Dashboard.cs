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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            button4.Hide();
            button5.Hide();
            button8.Hide();
            button9.Hide();
            button6.Hide();
            button7.Hide();

            pnlsys_des.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            prept.SendToBack();
            pqr.SendToBack();
            preg.BringToFront();

            button4.Show();
            button5.Show();
            button8.Hide();
            button9.Hide();
            button6.Hide();
            button7.Hide();
            pnlsys_des.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmstudentreg dsh = new frmstudentreg();
            dsh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            preg.SendToBack();
            pqr.BringToFront();
            prept.SendToBack();

            button4.Hide();
            button5.Hide();
            button8.Show();
            button9.Show();
            button6.Hide();
            button7.Hide();
            pnlsys_des.Hide();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 dsh = new Form1();
            dsh.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            preg.SendToBack();
            prept.BringToFront();
            pqr.SendToBack();

            button4.Hide();
            button5.Hide();
            button8.Hide();
            button9.Hide();
            button6.Show();
            button7.Show();
            pnlsys_des.Hide();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmstudentreg dsh = new frmstudentreg();
            dsh.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmstdSelection idfrm = new frmstdSelection();
            idfrm.Show();
        }

        private void btn_closefrm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImportMasterData impmd = new ImportMasterData();
            impmd.Show();
        }
    }
    }

