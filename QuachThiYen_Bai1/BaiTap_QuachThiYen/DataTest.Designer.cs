
namespace BaiTap_QuachThiYen
{
    partial class DataTest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BaiTap_QuachThiYen.DataSet1();
            this.dMKHOATableAdapter = new BaiTap_QuachThiYen.DataSet1TableAdapters.DMKHOATableAdapter();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGBANTableAdapter = new BaiTap_QuachThiYen.DataSet1TableAdapters.PHONGBANTableAdapter();
            this.dMKHOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dMKHOABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGBANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHOABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHOABindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dIACHIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dMKHOABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(221, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // dMKHOABindingSource
            // 
            this.dMKHOABindingSource.DataMember = "DMKHOA";
            this.dMKHOABindingSource.DataSource = this.dataSet1BindingSource;
            this.dMKHOABindingSource.CurrentChanged += new System.EventHandler(this.dMKHOABindingSource_CurrentChanged);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMKHOATableAdapter
            // 
            this.dMKHOATableAdapter.ClearBeforeFill = true;
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // dMKHOABindingSource1
            // 
            this.dMKHOABindingSource1.DataMember = "DMKHOA";
            this.dMKHOABindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // dMKHOABindingSource2
            // 
            this.dMKHOABindingSource2.DataMember = "DMKHOA";
            this.dMKHOABindingSource2.DataSource = this.dataSet1BindingSource;
            // 
            // pHONGBANBindingSource1
            // 
            this.pHONGBANBindingSource1.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // DataTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataTest";
            this.Text = "DataTest";
            this.Load += new System.EventHandler(this.DataTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHOABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHOABindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dMKHOABindingSource;
        private DataSet1TableAdapters.DMKHOATableAdapter dMKHOATableAdapter;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private DataSet1TableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource1;
        private System.Windows.Forms.BindingSource dMKHOABindingSource1;
        private System.Windows.Forms.BindingSource dMKHOABindingSource2;
    }
}