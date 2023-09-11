
namespace STSD
{
    partial class frmFindStd
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
            this.dataGridView_findstdmaster = new System.Windows.Forms.DataGridView();
            this.autorecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSchoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sclGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preDahamSclDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offGradeAttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offRegDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdStatusActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stdStatusResignDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stdStatusSuspDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stdStatusDismDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdQRDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fStdMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findStudentBDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.find_StudentBDS = new STSD.Find_StudentBDS();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsch = new System.Windows.Forms.TextBox();
            this.fStdMasterTableAdapter = new STSD.Find_StudentBDSTableAdapters.fStdMasterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_findstdmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStdMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findStudentBDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.find_StudentBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_findstdmaster
            // 
            this.dataGridView_findstdmaster.AutoGenerateColumns = false;
            this.dataGridView_findstdmaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_findstdmaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autorecDataGridViewTextBoxColumn,
            this.regIDDataGridViewTextBoxColumn,
            this.regCategoryDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.guardianDataGridViewTextBoxColumn,
            this.nameSchoolDataGridViewTextBoxColumn,
            this.sclGradeDataGridViewTextBoxColumn,
            this.preDahamSclDataGridViewTextBoxColumn,
            this.offGradeAttDataGridViewTextBoxColumn,
            this.offRegDateDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.stdStatusActiveDataGridViewCheckBoxColumn,
            this.stdStatusResignDataGridViewCheckBoxColumn,
            this.stdStatusSuspDataGridViewCheckBoxColumn,
            this.stdStatusDismDataGridViewCheckBoxColumn,
            this.addDateDataGridViewTextBoxColumn,
            this.stdImageDataGridViewImageColumn,
            this.stdQRDataGridViewImageColumn});
            this.dataGridView_findstdmaster.DataSource = this.fStdMasterBindingSource;
            this.dataGridView_findstdmaster.Location = new System.Drawing.Point(12, 150);
            this.dataGridView_findstdmaster.Name = "dataGridView_findstdmaster";
            this.dataGridView_findstdmaster.RowHeadersWidth = 51;
            this.dataGridView_findstdmaster.RowTemplate.Height = 24;
            this.dataGridView_findstdmaster.Size = new System.Drawing.Size(1336, 405);
            this.dataGridView_findstdmaster.TabIndex = 0;
            this.dataGridView_findstdmaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView_findstdmaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // autorecDataGridViewTextBoxColumn
            // 
            this.autorecDataGridViewTextBoxColumn.DataPropertyName = "Autorec";
            this.autorecDataGridViewTextBoxColumn.FillWeight = 122F;
            this.autorecDataGridViewTextBoxColumn.HeaderText = "Autorec";
            this.autorecDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorecDataGridViewTextBoxColumn.Name = "autorecDataGridViewTextBoxColumn";
            this.autorecDataGridViewTextBoxColumn.Width = 130;
            // 
            // regIDDataGridViewTextBoxColumn
            // 
            this.regIDDataGridViewTextBoxColumn.DataPropertyName = "RegID";
            this.regIDDataGridViewTextBoxColumn.HeaderText = "RegID";
            this.regIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regIDDataGridViewTextBoxColumn.Name = "regIDDataGridViewTextBoxColumn";
            this.regIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // regCategoryDataGridViewTextBoxColumn
            // 
            this.regCategoryDataGridViewTextBoxColumn.DataPropertyName = "RegCategory";
            this.regCategoryDataGridViewTextBoxColumn.HeaderText = "RegCategory";
            this.regCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regCategoryDataGridViewTextBoxColumn.Name = "regCategoryDataGridViewTextBoxColumn";
            this.regCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // guardianDataGridViewTextBoxColumn
            // 
            this.guardianDataGridViewTextBoxColumn.DataPropertyName = "Guardian";
            this.guardianDataGridViewTextBoxColumn.HeaderText = "Guardian";
            this.guardianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardianDataGridViewTextBoxColumn.Name = "guardianDataGridViewTextBoxColumn";
            this.guardianDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameSchoolDataGridViewTextBoxColumn
            // 
            this.nameSchoolDataGridViewTextBoxColumn.DataPropertyName = "NameSchool";
            this.nameSchoolDataGridViewTextBoxColumn.HeaderText = "NameSchool";
            this.nameSchoolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameSchoolDataGridViewTextBoxColumn.Name = "nameSchoolDataGridViewTextBoxColumn";
            this.nameSchoolDataGridViewTextBoxColumn.Width = 125;
            // 
            // sclGradeDataGridViewTextBoxColumn
            // 
            this.sclGradeDataGridViewTextBoxColumn.DataPropertyName = "SclGrade";
            this.sclGradeDataGridViewTextBoxColumn.HeaderText = "SclGrade";
            this.sclGradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sclGradeDataGridViewTextBoxColumn.Name = "sclGradeDataGridViewTextBoxColumn";
            this.sclGradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // preDahamSclDataGridViewTextBoxColumn
            // 
            this.preDahamSclDataGridViewTextBoxColumn.DataPropertyName = "PreDahamScl";
            this.preDahamSclDataGridViewTextBoxColumn.HeaderText = "PreDahamScl";
            this.preDahamSclDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preDahamSclDataGridViewTextBoxColumn.Name = "preDahamSclDataGridViewTextBoxColumn";
            this.preDahamSclDataGridViewTextBoxColumn.Width = 125;
            // 
            // offGradeAttDataGridViewTextBoxColumn
            // 
            this.offGradeAttDataGridViewTextBoxColumn.DataPropertyName = "OffGradeAtt";
            this.offGradeAttDataGridViewTextBoxColumn.HeaderText = "OffGradeAtt";
            this.offGradeAttDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offGradeAttDataGridViewTextBoxColumn.Name = "offGradeAttDataGridViewTextBoxColumn";
            this.offGradeAttDataGridViewTextBoxColumn.Width = 125;
            // 
            // offRegDateDataGridViewTextBoxColumn
            // 
            this.offRegDateDataGridViewTextBoxColumn.DataPropertyName = "OffRegDate";
            this.offRegDateDataGridViewTextBoxColumn.HeaderText = "OffRegDate";
            this.offRegDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offRegDateDataGridViewTextBoxColumn.Name = "offRegDateDataGridViewTextBoxColumn";
            this.offRegDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdStatusActiveDataGridViewCheckBoxColumn
            // 
            this.stdStatusActiveDataGridViewCheckBoxColumn.DataPropertyName = "StdStatus_Active";
            this.stdStatusActiveDataGridViewCheckBoxColumn.HeaderText = "StdStatus_Active";
            this.stdStatusActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.stdStatusActiveDataGridViewCheckBoxColumn.Name = "stdStatusActiveDataGridViewCheckBoxColumn";
            this.stdStatusActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // stdStatusResignDataGridViewCheckBoxColumn
            // 
            this.stdStatusResignDataGridViewCheckBoxColumn.DataPropertyName = "StdStatus_Resign";
            this.stdStatusResignDataGridViewCheckBoxColumn.HeaderText = "StdStatus_Resign";
            this.stdStatusResignDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.stdStatusResignDataGridViewCheckBoxColumn.Name = "stdStatusResignDataGridViewCheckBoxColumn";
            this.stdStatusResignDataGridViewCheckBoxColumn.Width = 125;
            // 
            // stdStatusSuspDataGridViewCheckBoxColumn
            // 
            this.stdStatusSuspDataGridViewCheckBoxColumn.DataPropertyName = "StdStatus_Susp";
            this.stdStatusSuspDataGridViewCheckBoxColumn.HeaderText = "StdStatus_Susp";
            this.stdStatusSuspDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.stdStatusSuspDataGridViewCheckBoxColumn.Name = "stdStatusSuspDataGridViewCheckBoxColumn";
            this.stdStatusSuspDataGridViewCheckBoxColumn.Width = 125;
            // 
            // stdStatusDismDataGridViewCheckBoxColumn
            // 
            this.stdStatusDismDataGridViewCheckBoxColumn.DataPropertyName = "StdStatus_Dism";
            this.stdStatusDismDataGridViewCheckBoxColumn.HeaderText = "StdStatus_Dism";
            this.stdStatusDismDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.stdStatusDismDataGridViewCheckBoxColumn.Name = "stdStatusDismDataGridViewCheckBoxColumn";
            this.stdStatusDismDataGridViewCheckBoxColumn.Width = 125;
            // 
            // addDateDataGridViewTextBoxColumn
            // 
            this.addDateDataGridViewTextBoxColumn.DataPropertyName = "AddDate";
            this.addDateDataGridViewTextBoxColumn.HeaderText = "AddDate";
            this.addDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addDateDataGridViewTextBoxColumn.Name = "addDateDataGridViewTextBoxColumn";
            this.addDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdImageDataGridViewImageColumn
            // 
            this.stdImageDataGridViewImageColumn.DataPropertyName = "stdImage";
            this.stdImageDataGridViewImageColumn.HeaderText = "stdImage";
            this.stdImageDataGridViewImageColumn.MinimumWidth = 6;
            this.stdImageDataGridViewImageColumn.Name = "stdImageDataGridViewImageColumn";
            this.stdImageDataGridViewImageColumn.Width = 125;
            // 
            // stdQRDataGridViewImageColumn
            // 
            this.stdQRDataGridViewImageColumn.DataPropertyName = "stdQR";
            this.stdQRDataGridViewImageColumn.HeaderText = "stdQR";
            this.stdQRDataGridViewImageColumn.MinimumWidth = 6;
            this.stdQRDataGridViewImageColumn.Name = "stdQRDataGridViewImageColumn";
            this.stdQRDataGridViewImageColumn.Width = 125;
            // 
            // fStdMasterBindingSource
            // 
            this.fStdMasterBindingSource.DataMember = "fStdMaster";
            this.fStdMasterBindingSource.DataSource = this.findStudentBDSBindingSource;
            // 
            // findStudentBDSBindingSource
            // 
            this.findStudentBDSBindingSource.DataSource = this.find_StudentBDS;
            this.findStudentBDSBindingSource.Position = 0;
            // 
            // find_StudentBDS
            // 
            this.find_StudentBDS.DataSetName = "Find_StudentBDS";
            this.find_StudentBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "සිසුවා/සිසුවිය තේරීම\r\n(Find Students)";
            // 
            // txtsch
            // 
            this.txtsch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsch.Location = new System.Drawing.Point(232, 69);
            this.txtsch.Name = "txtsch";
            this.txtsch.Size = new System.Drawing.Size(650, 32);
            this.txtsch.TabIndex = 4;
            this.txtsch.TextChanged += new System.EventHandler(this.txtsch_TextChanged);
            // 
            // fStdMasterTableAdapter
            // 
            this.fStdMasterTableAdapter.ClearBeforeFill = true;
            // 
            // frmFindStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsch);
            this.Controls.Add(this.dataGridView_findstdmaster);
            this.Name = "frmFindStd";
            this.Text = "Find Window";
            this.Load += new System.EventHandler(this.frmFindStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_findstdmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fStdMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findStudentBDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.find_StudentBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_findstdmaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsch;
        private System.Windows.Forms.BindingSource findStudentBDSBindingSource;
        private Find_StudentBDS find_StudentBDS;
        private System.Windows.Forms.BindingSource fStdMasterBindingSource;
        private Find_StudentBDSTableAdapters.fStdMasterTableAdapter fStdMasterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSchoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sclGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preDahamSclDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offGradeAttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offRegDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stdStatusActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stdStatusResignDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stdStatusSuspDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stdStatusDismDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn stdImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn stdQRDataGridViewImageColumn;
    }
}