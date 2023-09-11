
namespace STSD
{
    partial class frmBulkIDPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ftempstdIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSID = new STSD.DSID();
            this.fStdMasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bPSolutionDataSet1 = new STSD.BPSolutionDataSet1();
            this.fStdMaster1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bPSolutionDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BPSolutionDataSet2 = new STSD.BPSolutionDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ftempstdIDTableAdapter = new STSD.DSIDTableAdapters.ftempstdIDTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_closefrm = new System.Windows.Forms.Button();
            this.btnupdsvr = new System.Windows.Forms.Button();
            this.fStdMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fStdMaster1TableAdapter = new STSD.BPSolutionDataSet2TableAdapters.fStdMaster1TableAdapter();
            this.bPSolutionDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fStdMasterTableAdapter = new STSD.BPSolutionDataSet1TableAdapters.fStdMasterTableAdapter();
            this.stdSelection_grid_print = new STSD.stdSelection_grid_print();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ftempstdIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStdMasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSolutionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStdMaster1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSolutionDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BPSolutionDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fStdMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSolutionDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdSelection_grid_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ftempstdIDBindingSource
            // 
            this.ftempstdIDBindingSource.DataMember = "ftempstdID";
            this.ftempstdIDBindingSource.DataSource = this.DSID;
            // 
            // DSID
            // 
            this.DSID.DataSetName = "DSID";
            this.DSID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fStdMasterBindingSource1
            // 
            this.fStdMasterBindingSource1.DataMember = "fStdMaster";
            this.fStdMasterBindingSource1.DataSource = this.bPSolutionDataSet1;
            // 
            // bPSolutionDataSet1
            // 
            this.bPSolutionDataSet1.DataSetName = "BPSolutionDataSet1";
            this.bPSolutionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fStdMaster1BindingSource
            // 
            this.fStdMaster1BindingSource.DataMember = "fStdMaster1";
            this.fStdMaster1BindingSource.DataSource = this.bPSolutionDataSet2BindingSource;
            // 
            // bPSolutionDataSet2BindingSource
            // 
            this.bPSolutionDataSet2BindingSource.DataSource = this.BPSolutionDataSet2;
            this.bPSolutionDataSet2BindingSource.Position = 0;
            // 
            // BPSolutionDataSet2
            // 
            this.BPSolutionDataSet2.DataSetName = "BPSolutionDataSet2";
            this.BPSolutionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "STQRID";
            reportDataSource2.Value = this.ftempstdIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "STSD.fqrgen_STDID.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(907, 135);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(898, 748);
            this.reportViewer1.TabIndex = 0;
            // 
            // ftempstdIDTableAdapter
            // 
            this.ftempstdIDTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_closefrm);
            this.panel1.Controls.Add(this.btnupdsvr);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1851, 73);
            this.panel1.TabIndex = 10;
            // 
            // btn_closefrm
            // 
            this.btn_closefrm.BackgroundImage = global::STSD.Properties.Resources.Windows_Turn_Off_icon;
            this.btn_closefrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_closefrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closefrm.Location = new System.Drawing.Point(1748, 12);
            this.btn_closefrm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_closefrm.Name = "btn_closefrm";
            this.btn_closefrm.Size = new System.Drawing.Size(56, 55);
            this.btn_closefrm.TabIndex = 9;
            this.btn_closefrm.UseVisualStyleBackColor = true;
            this.btn_closefrm.Click += new System.EventHandler(this.btn_closefrm_Click);
            // 
            // btnupdsvr
            // 
            this.btnupdsvr.BackColor = System.Drawing.Color.MediumBlue;
            this.btnupdsvr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdsvr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdsvr.Location = new System.Drawing.Point(1365, 12);
            this.btnupdsvr.Name = "btnupdsvr";
            this.btnupdsvr.Size = new System.Drawing.Size(355, 53);
            this.btnupdsvr.TabIndex = 4;
            this.btnupdsvr.Text = "Update  Server - After Printing Process";
            this.btnupdsvr.UseVisualStyleBackColor = false;
            this.btnupdsvr.Click += new System.EventHandler(this.btnupdsvr_Click);
            // 
            // fStdMasterBindingSource
            // 
            this.fStdMasterBindingSource.DataMember = "fStdMaster";
            this.fStdMasterBindingSource.DataSource = this.BPSolutionDataSet2;
            // 
            // fStdMaster1TableAdapter
            // 
            this.fStdMaster1TableAdapter.ClearBeforeFill = true;
            // 
            // bPSolutionDataSet1BindingSource
            // 
            this.bPSolutionDataSet1BindingSource.DataSource = this.bPSolutionDataSet1;
            this.bPSolutionDataSet1BindingSource.Position = 0;
            // 
            // fStdMasterTableAdapter
            // 
            this.fStdMasterTableAdapter.ClearBeforeFill = true;
            // 
            // stdSelection_grid_print
            // 
            this.stdSelection_grid_print.DataSetName = "stdSelection_grid_print";
            this.stdSelection_grid_print.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(142, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 25);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ශිෂ්‍ය ලියාපදිංචිය ";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.linkLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(37, 322);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabHighProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(450, 52);
            this.kryptonPanel1.TabIndex = 13;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel2.Location = new System.Drawing.Point(17, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(408, 25);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "හැදුනුම්පත සැකසීමට අවශ්‍ය සිසුන් තෝරාගැනීම";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.linkLabel2);
            this.kryptonPanel2.Location = new System.Drawing.Point(37, 443);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabHighProfile;
            this.kryptonPanel2.Size = new System.Drawing.Size(450, 52);
            this.kryptonPanel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STSD.Properties.Resources._10_2_arrow_png;
            this.pictureBox1.Location = new System.Drawing.Point(493, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::STSD.Properties.Resources._77948_blue_light_creativity_effect_arrow_hq_image_free_png;
            this.pictureBox2.Location = new System.Drawing.Point(233, 384);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::STSD.Properties.Resources._77948_blue_light_creativity_effect_arrow_hq_image_free_png;
            this.pictureBox3.Location = new System.Drawing.Point(233, 516);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.linkLabel3);
            this.kryptonPanel3.Location = new System.Drawing.Point(37, 586);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabHighProfile;
            this.kryptonPanel3.Size = new System.Drawing.Size(450, 52);
            this.kryptonPanel3.TabIndex = 20;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel3.Location = new System.Drawing.Point(142, 15);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(170, 25);
            this.linkLabel3.TabIndex = 11;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "හැදුනුම්පත මුද්‍රණය";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(27, 119);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 58);
            this.label1.TabIndex = 21;
            this.label1.Text = "ඔබට අවශ්‍ය පරිදි මෙහිදී ශිෂ්‍ය හැදුනුම්පත් මුද්‍රණය කරගත \r\nහැකිවන පරිදි පහත උපදෙස" +
    "් සදහන් කර ඇත.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "ශිෂ්‍ය හැදුනුම්පත සදහා QR සංකේතය\r\nස්වයංක්‍රියව සකසා ගැනීම\r\n";
            // 
            // frmBulkIDPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 895);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBulkIDPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student ID - Bulk Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBulkIDPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftempstdIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStdMasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSolutionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStdMaster1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSolutionDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BPSolutionDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
           // ((System.ComponentModel.ISupportInitialize)(this.fStdMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSolutionDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdSelection_grid_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ftempstdIDBindingSource;
        private DSID DSID;
        private DSIDTableAdapters.ftempstdIDTableAdapter ftempstdIDTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_closefrm;
        private System.Windows.Forms.Button btnupdsvr;
        private System.Windows.Forms.BindingSource fStdMasterBindingSource;
        private BPSolutionDataSet2 BPSolutionDataSet2;
        private System.Windows.Forms.BindingSource bPSolutionDataSet2BindingSource;
        private System.Windows.Forms.BindingSource fStdMaster1BindingSource;
        private BPSolutionDataSet2TableAdapters.fStdMaster1TableAdapter fStdMaster1TableAdapter;
        private BPSolutionDataSet1 bPSolutionDataSet1;
        private System.Windows.Forms.BindingSource bPSolutionDataSet1BindingSource;
        private System.Windows.Forms.BindingSource fStdMasterBindingSource1;
        private BPSolutionDataSet1TableAdapters.fStdMasterTableAdapter fStdMasterTableAdapter;
        private stdSelection_grid_print stdSelection_grid_print;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}