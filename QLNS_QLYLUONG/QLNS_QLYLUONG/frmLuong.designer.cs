
namespace QLNS_QLYLUONG
{
    partial class frmLuong
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
            this.txtMaLuong = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuongCoBan = new System.Windows.Forms.NumericUpDown();
            this.txtCong = new System.Windows.Forms.NumericUpDown();
            this.txtTru = new System.Windows.Forms.NumericUpDown();
            this.txtThucLinh = new System.Windows.Forms.NumericUpDown();
            this.checkMaNV = new System.Windows.Forms.CheckBox();
            this.checkMaPB = new System.Windows.Forms.CheckBox();
            this.cboTKMaNV = new System.Windows.Forms.ComboBox();
            this.cboTKMaPB = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCoBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThucLinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaLuong
            // 
            this.txtMaLuong.Location = new System.Drawing.Point(135, 66);
            this.txtMaLuong.Name = "txtMaLuong";
            this.txtMaLuong.Size = new System.Drawing.Size(129, 20);
            this.txtMaLuong.TabIndex = 1;
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(649, 80);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 23);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo mới";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(135, 98);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(129, 21);
            this.cboMaNV.TabIndex = 3;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(43, 275);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(562, 119);
            this.dataGrid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lương:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lương cơ bản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoản cộng thêm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khoản trừ:";
            // 
            // btnChen
            // 
            this.btnChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChen.Location = new System.Drawing.Point(649, 134);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(75, 23);
            this.btnChen.TabIndex = 2;
            this.btnChen.Text = "Chèn";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(649, 187);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(649, 233);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(649, 275);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(478, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "THÔNG TIN CƠ BẢN VỀ LƯƠNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thực lĩnh";
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Location = new System.Drawing.Point(135, 132);
            this.txtLuongCoBan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(129, 20);
            this.txtLuongCoBan.TabIndex = 5;
            // 
            // txtCong
            // 
            this.txtCong.Location = new System.Drawing.Point(424, 67);
            this.txtCong.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtCong.Name = "txtCong";
            this.txtCong.Size = new System.Drawing.Size(129, 20);
            this.txtCong.TabIndex = 5;
            // 
            // txtTru
            // 
            this.txtTru.Location = new System.Drawing.Point(424, 101);
            this.txtTru.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtTru.Name = "txtTru";
            this.txtTru.Size = new System.Drawing.Size(129, 20);
            this.txtTru.TabIndex = 5;
            // 
            // txtThucLinh
            // 
            this.txtThucLinh.Location = new System.Drawing.Point(424, 134);
            this.txtThucLinh.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtThucLinh.Name = "txtThucLinh";
            this.txtThucLinh.Size = new System.Drawing.Size(129, 20);
            this.txtThucLinh.TabIndex = 5;
            // 
            // checkMaNV
            // 
            this.checkMaNV.AutoSize = true;
            this.checkMaNV.Location = new System.Drawing.Point(54, 181);
            this.checkMaNV.Name = "checkMaNV";
            this.checkMaNV.Size = new System.Drawing.Size(189, 17);
            this.checkMaNV.TabIndex = 6;
            this.checkMaNV.Text = "Tìm kiếm lương theo Mã nhân viên";
            this.checkMaNV.UseVisualStyleBackColor = true;
            // 
            // checkMaPB
            // 
            this.checkMaPB.AutoSize = true;
            this.checkMaPB.Location = new System.Drawing.Point(54, 214);
            this.checkMaPB.Name = "checkMaPB";
            this.checkMaPB.Size = new System.Drawing.Size(193, 17);
            this.checkMaPB.TabIndex = 6;
            this.checkMaPB.Text = "Tìm kiếm lương theo Mã phòng ban";
            this.checkMaPB.UseVisualStyleBackColor = true;
            // 
            // cboTKMaNV
            // 
            this.cboTKMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKMaNV.FormattingEnabled = true;
            this.cboTKMaNV.Location = new System.Drawing.Point(250, 177);
            this.cboTKMaNV.Name = "cboTKMaNV";
            this.cboTKMaNV.Size = new System.Drawing.Size(129, 21);
            this.cboTKMaNV.TabIndex = 3;
            // 
            // cboTKMaPB
            // 
            this.cboTKMaPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKMaPB.FormattingEnabled = true;
            this.cboTKMaPB.Location = new System.Drawing.Point(250, 210);
            this.cboTKMaPB.Name = "cboTKMaPB";
            this.cboTKMaPB.Size = new System.Drawing.Size(129, 21);
            this.cboTKMaPB.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(424, 187);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkMaPB);
            this.Controls.Add(this.checkMaNV);
            this.Controls.Add(this.txtThucLinh);
            this.Controls.Add(this.txtTru);
            this.Controls.Add(this.txtCong);
            this.Controls.Add(this.txtLuongCoBan);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.cboTKMaNV);
            this.Controls.Add(this.cboTKMaPB);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtMaLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Name = "frmLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.frmLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCoBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThucLinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaLuong;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtLuongCoBan;
        private System.Windows.Forms.NumericUpDown txtCong;
        private System.Windows.Forms.NumericUpDown txtTru;
        private System.Windows.Forms.NumericUpDown txtThucLinh;
        private System.Windows.Forms.CheckBox checkMaNV;
        private System.Windows.Forms.CheckBox checkMaPB;
        private System.Windows.Forms.ComboBox cboTKMaNV;
        private System.Windows.Forms.ComboBox cboTKMaPB;
        private System.Windows.Forms.Button btnTimKiem;
    }
}