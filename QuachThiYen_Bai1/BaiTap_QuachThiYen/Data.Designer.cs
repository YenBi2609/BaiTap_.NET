
namespace BaiTap_QuachThiYen
{
    partial class Data
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
            this.dataSet3 = new BaiTap_QuachThiYen.DataSet3();
            this.dangNhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dangNhapTableAdapter1 = new BaiTap_QuachThiYen.DataSet3TableAdapters.DangNhapTableAdapter();
            this.tênĐăngNhậpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mậtKhẩuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tênĐăngNhậpDataGridViewTextBoxColumn,
            this.mậtKhẩuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dangNhapBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(295, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(291, 145);
            this.dataGridView1.TabIndex = 0;
            // 
            // 
            // dataSet1BindingSource
            // 
            // dangNhapTableAdapter
            // 
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangNhapBindingSource1
            // 
            this.dangNhapBindingSource1.DataMember = "DangNhap";
            this.dangNhapBindingSource1.DataSource = this.dataSet3;
            // 
            // dangNhapTableAdapter1
            // 
            this.dangNhapTableAdapter1.ClearBeforeFill = true;
            // 
            // tênĐăngNhậpDataGridViewTextBoxColumn
            // 
            this.tênĐăngNhậpDataGridViewTextBoxColumn.DataPropertyName = "Tên đăng nhập";
            this.tênĐăngNhậpDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tênĐăngNhậpDataGridViewTextBoxColumn.Name = "tênĐăngNhậpDataGridViewTextBoxColumn";
            // 
            // mậtKhẩuDataGridViewTextBoxColumn
            // 
            this.mậtKhẩuDataGridViewTextBoxColumn.DataPropertyName = "Mật khẩu";
            this.mậtKhẩuDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.mậtKhẩuDataGridViewTextBoxColumn.Name = "mậtKhẩuDataGridViewTextBoxColumn";
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

//            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        //private DataSet1 dataSet1;
        //private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource dangNhapBindingSource;
        //private DataSet2TableAdapters.DangNhapTableAdapter dangNhapTableAdapter;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource dangNhapBindingSource1;
        private DataSet3TableAdapters.DangNhapTableAdapter dangNhapTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênĐăngNhậpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mậtKhẩuDataGridViewTextBoxColumn;
    }
}