
namespace STSD
{
    partial class ImportMasterData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cboSheet = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnImport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnbrw = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvStudent = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ofdSelect = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cboSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sheet :";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(141, 619);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(730, 27);
            this.txtPath.TabIndex = 3;
            // 
            // cboSheet
            // 
            this.cboSheet.DropDownWidth = 203;
            this.cboSheet.Location = new System.Drawing.Point(141, 654);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(203, 25);
            this.cboSheet.TabIndex = 4;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // btnImport
            // 
            this.btnImport.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.btnImport.Location = new System.Drawing.Point(1097, 607);
            this.btnImport.Name = "btnImport";
            this.btnImport.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnImport.Size = new System.Drawing.Size(90, 72);
            this.btnImport.TabIndex = 5;
            this.btnImport.Values.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnbrw
            // 
            this.btnbrw.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnbrw.Location = new System.Drawing.Point(877, 619);
            this.btnbrw.Name = "btnbrw";
            this.btnbrw.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnbrw.Size = new System.Drawing.Size(64, 27);
            this.btnbrw.TabIndex = 6;
            this.btnbrw.Values.Text = "...";
            this.btnbrw.Click += new System.EventHandler(this.btnbrw_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(28, 33);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(1159, 549);
            this.dgvStudent.TabIndex = 0;
            // 
            // ofdSelect
            // 
            this.ofdSelect.FileName = "openFileDialog1";
            // 
            // ImportMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 707);
            this.Controls.Add(this.btnbrw);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudent);
            this.Name = "ImportMasterData";
            this.Text = "Import Master Data";
            this.Load += new System.EventHandler(this.ImportMasterData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPath;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboSheet;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnImport;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnbrw;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvStudent;
        private System.Windows.Forms.OpenFileDialog ofdSelect;
    }
}