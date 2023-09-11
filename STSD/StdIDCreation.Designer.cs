
namespace STSD
{
    partial class StdIDCreation
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Print1 = new System.Windows.Forms.Button();
            this.btn_closefrm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.stdRegCatg = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stdRegDate = new System.Windows.Forms.TextBox();
            this.stdName = new System.Windows.Forms.TextBox();
            this.stdID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DSID = new STSD.DSID();
            this.ftempstdIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ftempstdIDTableAdapter = new STSD.DSIDTableAdapters.ftempstdIDTableAdapter();
            this.ftempstdIDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftempstdIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftempstdIDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(714, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Print1);
            this.panel1.Controls.Add(this.btn_closefrm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 67);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Print1
            // 
            this.btn_Print1.BackgroundImage = global::STSD.Properties.Resources._1;
            this.btn_Print1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Print1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print1.Location = new System.Drawing.Point(1171, 11);
            this.btn_Print1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Print1.Name = "btn_Print1";
            this.btn_Print1.Size = new System.Drawing.Size(56, 49);
            this.btn_Print1.TabIndex = 10;
            this.btn_Print1.UseVisualStyleBackColor = true;
            // 
            // btn_closefrm
            // 
            this.btn_closefrm.BackgroundImage = global::STSD.Properties.Resources.Windows_Turn_Off_icon;
            this.btn_closefrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_closefrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closefrm.Location = new System.Drawing.Point(1262, 11);
            this.btn_closefrm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_closefrm.Name = "btn_closefrm";
            this.btn_closefrm.Size = new System.Drawing.Size(56, 49);
            this.btn_closefrm.TabIndex = 9;
            this.btn_closefrm.UseVisualStyleBackColor = true;
            this.btn_closefrm.Click += new System.EventHandler(this.btn_closefrm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.stdRegCatg);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.stdRegDate);
            this.groupBox1.Controls.Add(this.stdName);
            this.groupBox1.Controls.Add(this.stdID);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(21, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 584);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID Details Confirmation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(23, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "ශිෂ්‍යය / ශිෂ්‍යයාවගේ නම";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(23, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "ඇතුලත්වීමේ අංකය";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(23, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "ඇතුලත්වීමේ කාණ්ඩය";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(23, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "ඇතුලත් කරගත් දිනය";
            // 
            // stdRegCatg
            // 
            this.stdRegCatg.Location = new System.Drawing.Point(224, 251);
            this.stdRegCatg.Name = "stdRegCatg";
            this.stdRegCatg.Size = new System.Drawing.Size(148, 22);
            this.stdRegCatg.TabIndex = 38;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(253, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 72);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // stdRegDate
            // 
            this.stdRegDate.Location = new System.Drawing.Point(224, 405);
            this.stdRegDate.Name = "stdRegDate";
            this.stdRegDate.Size = new System.Drawing.Size(237, 22);
            this.stdRegDate.TabIndex = 36;
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(224, 327);
            this.stdName.Multiline = true;
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(352, 65);
            this.stdName.TabIndex = 35;
            // 
            // stdID
            // 
            this.stdID.Location = new System.Drawing.Point(224, 292);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(352, 22);
            this.stdID.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 186);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(660, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 584);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ID Print Preview";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(201, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "හැදුනුම්පත පසුපස (Back Side of the ID)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(201, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "හැදුනුම්පත ඉදිරිපස (Front Side of the ID)";
            // 
            // DSID
            // 
            this.DSID.DataSetName = "DSID";
            this.DSID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ftempstdIDBindingSource
            // 
            this.ftempstdIDBindingSource.DataMember = "ftempstdID";
            this.ftempstdIDBindingSource.DataSource = this.DSID;
            // 
            // ftempstdIDTableAdapter
            // 
            this.ftempstdIDTableAdapter.ClearBeforeFill = true;
            // 
            // ftempstdIDBindingSource1
            // 
            this.ftempstdIDBindingSource1.DataMember = "ftempstdID";
            this.ftempstdIDBindingSource1.DataSource = this.DSID;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "stdIDDS";
            reportDataSource1.Value = this.ftempstdIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "STSD.RptID.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(68, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(558, 246);
            this.reportViewer1.TabIndex = 43;
            // 
            // StdIDCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 691);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StdIDCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StdIDCreation";
            this.Load += new System.EventHandler(this.StdIDCreation_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftempstdIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftempstdIDBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox stdRegCatg;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox stdRegDate;
        public System.Windows.Forms.TextBox stdName;
        public System.Windows.Forms.TextBox stdID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Print1;
        private System.Windows.Forms.Button btn_closefrm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ftempstdIDBindingSource;
        private DSID DSID;
        private DSIDTableAdapters.ftempstdIDTableAdapter ftempstdIDTableAdapter;
        private System.Windows.Forms.BindingSource ftempstdIDBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}