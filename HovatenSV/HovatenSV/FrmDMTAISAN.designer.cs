
namespace HovatenSV
{
    partial class FrmDMTAISAN
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
            this.txtMaTaiSan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtaGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenTaiSan = new System.Windows.Forms.TextBox();
            this.txtNamSX = new System.Windows.Forms.TextBox();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaLoaiTS = new System.Windows.Forms.ComboBox();
            this.cboMaDV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaTaiSan
            // 
            this.txtMaTaiSan.Location = new System.Drawing.Point(200, 91);
            this.txtMaTaiSan.Name = "txtMaTaiSan";
            this.txtMaTaiSan.Size = new System.Drawing.Size(366, 20);
            this.txtMaTaiSan.TabIndex = 0;
            this.txtMaTaiSan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN DANH MỤC TÀI SẢN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(623, 155);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sủa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtaGrid
            // 
            this.dtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGrid.Location = new System.Drawing.Point(106, 263);
            this.dtaGrid.Name = "dtaGrid";
            this.dtaGrid.Size = new System.Drawing.Size(559, 128);
            this.dtaGrid.TabIndex = 3;
            this.dtaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Tài Sản:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Tài Sản:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nước Sản Xuất:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Loại Tài Sản:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Năm Sản Xuất:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.Location = new System.Drawing.Point(200, 117);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Size = new System.Drawing.Size(366, 20);
            this.txtTenTaiSan.TabIndex = 0;
            // 
            // txtNamSX
            // 
            this.txtNamSX.Location = new System.Drawing.Point(200, 143);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(366, 20);
            this.txtNamSX.TabIndex = 0;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(200, 169);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(366, 20);
            this.txtNuocSX.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(623, 192);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChen
            // 
            this.btnChen.Location = new System.Drawing.Point(623, 126);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(75, 23);
            this.btnChen.TabIndex = 2;
            this.btnChen.Text = "Chèn";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(623, 221);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(623, 97);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 23);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo mới";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã Đơn Vị:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboMaLoaiTS
            // 
            this.cboMaLoaiTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLoaiTS.FormattingEnabled = true;
            this.cboMaLoaiTS.Location = new System.Drawing.Point(207, 193);
            this.cboMaLoaiTS.Name = "cboMaLoaiTS";
            this.cboMaLoaiTS.Size = new System.Drawing.Size(359, 21);
            this.cboMaLoaiTS.TabIndex = 4;
            // 
            // cboMaDV
            // 
            this.cboMaDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDV.FormattingEnabled = true;
            this.cboMaDV.Location = new System.Drawing.Point(207, 218);
            this.cboMaDV.Name = "cboMaDV";
            this.cboMaDV.Size = new System.Drawing.Size(359, 21);
            this.cboMaDV.TabIndex = 4;
            // 
            // FrmDMTAISAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMaDV);
            this.Controls.Add(this.cboMaLoaiTS);
            this.Controls.Add(this.dtaGrid);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuocSX);
            this.Controls.Add(this.txtNamSX);
            this.Controls.Add(this.txtTenTaiSan);
            this.Controls.Add(this.txtMaTaiSan);
            this.Name = "FrmDMTAISAN";
            this.Text = "FrmDMTAISAN";
            this.Load += new System.EventHandler(this.FrmDMTAISAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaTaiSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dtaGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenTaiSan;
        private System.Windows.Forms.TextBox txtNamSX;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaLoaiTS;
        private System.Windows.Forms.ComboBox cboMaDV;
    }
}