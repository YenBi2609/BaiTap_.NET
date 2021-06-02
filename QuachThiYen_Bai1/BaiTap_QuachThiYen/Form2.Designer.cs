
namespace BaiTap_QuachThiYen
{
    partial class Form2
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
            this.radNam = new System.Windows.Forms.RadioButton();
            this.chkKhoiA = new System.Windows.Forms.CheckBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.lblXem = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.btnXem = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.grpUuTien = new System.Windows.Forms.GroupBox();
            this.radKhong = new System.Windows.Forms.RadioButton();
            this.radCo = new System.Windows.Forms.RadioButton();
            this.grpKhoiThi = new System.Windows.Forms.GroupBox();
            this.chkKhoiA1 = new System.Windows.Forms.CheckBox();
            this.chkKhoiD0 = new System.Windows.Forms.CheckBox();
            this.chkKhoiD7 = new System.Windows.Forms.CheckBox();
            this.chkKhoiB = new System.Windows.Forms.CheckBox();
            this.grpGioiTinh.SuspendLayout();
            this.grpUuTien.SuspendLayout();
            this.grpKhoiThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(111, 60);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 0;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // chkKhoiA
            // 
            this.chkKhoiA.AutoSize = true;
            this.chkKhoiA.Checked = true;
            this.chkKhoiA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKhoiA.Location = new System.Drawing.Point(15, 31);
            this.chkKhoiA.Name = "chkKhoiA";
            this.chkKhoiA.Size = new System.Drawing.Size(57, 17);
            this.chkKhoiA.TabIndex = 1;
            this.chkKhoiA.Text = "Khối A";
            this.chkKhoiA.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(111, 252);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnKetQua.TabIndex = 2;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // lblXem
            // 
            this.lblXem.AutoSize = true;
            this.lblXem.Location = new System.Drawing.Point(227, 202);
            this.lblXem.Name = "lblXem";
            this.lblXem.Size = new System.Drawing.Size(36, 13);
            this.lblXem.TabIndex = 3;
            this.lblXem.Text = "TB:....";
            this.lblXem.Click += new System.EventHandler(this.label1_Click);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Checked = true;
            this.radNu.Location = new System.Drawing.Point(49, 51);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 0;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(111, 197);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(227, 257);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(36, 13);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "TB:....";
            this.lblKetQua.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpGioiTinh
            // 
            this.grpGioiTinh.Controls.Add(this.radNu);
            this.grpGioiTinh.Location = new System.Drawing.Point(62, 44);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(200, 100);
            this.grpGioiTinh.TabIndex = 4;
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới tính";
            // 
            // grpUuTien
            // 
            this.grpUuTien.Controls.Add(this.radKhong);
            this.grpUuTien.Location = new System.Drawing.Point(285, 45);
            this.grpUuTien.Name = "grpUuTien";
            this.grpUuTien.Size = new System.Drawing.Size(200, 100);
            this.grpUuTien.TabIndex = 4;
            this.grpUuTien.TabStop = false;
            this.grpUuTien.Text = "Ưu tiên";
            // 
            // radKhong
            // 
            this.radKhong.AutoSize = true;
            this.radKhong.Location = new System.Drawing.Point(49, 51);
            this.radKhong.Name = "radKhong";
            this.radKhong.Size = new System.Drawing.Size(56, 17);
            this.radKhong.TabIndex = 0;
            this.radKhong.TabStop = true;
            this.radKhong.Text = "Không";
            this.radKhong.UseVisualStyleBackColor = true;
            // 
            // radCo
            // 
            this.radCo.AutoSize = true;
            this.radCo.Checked = true;
            this.radCo.Location = new System.Drawing.Point(334, 61);
            this.radCo.Name = "radCo";
            this.radCo.Size = new System.Drawing.Size(38, 17);
            this.radCo.TabIndex = 0;
            this.radCo.TabStop = true;
            this.radCo.Text = "Có";
            this.radCo.UseVisualStyleBackColor = true;
            // 
            // grpKhoiThi
            // 
            this.grpKhoiThi.Controls.Add(this.chkKhoiB);
            this.grpKhoiThi.Controls.Add(this.chkKhoiD7);
            this.grpKhoiThi.Controls.Add(this.chkKhoiD0);
            this.grpKhoiThi.Controls.Add(this.chkKhoiA1);
            this.grpKhoiThi.Controls.Add(this.chkKhoiA);
            this.grpKhoiThi.Location = new System.Drawing.Point(525, 45);
            this.grpKhoiThi.Name = "grpKhoiThi";
            this.grpKhoiThi.Size = new System.Drawing.Size(146, 156);
            this.grpKhoiThi.TabIndex = 5;
            this.grpKhoiThi.TabStop = false;
            this.grpKhoiThi.Text = "Khối thi";
            // 
            // chkKhoiA1
            // 
            this.chkKhoiA1.AutoSize = true;
            this.chkKhoiA1.Checked = true;
            this.chkKhoiA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKhoiA1.Location = new System.Drawing.Point(15, 50);
            this.chkKhoiA1.Name = "chkKhoiA1";
            this.chkKhoiA1.Size = new System.Drawing.Size(63, 17);
            this.chkKhoiA1.TabIndex = 1;
            this.chkKhoiA1.Text = "Khối A1";
            this.chkKhoiA1.UseVisualStyleBackColor = true;
            // 
            // chkKhoiD0
            // 
            this.chkKhoiD0.AutoSize = true;
            this.chkKhoiD0.Location = new System.Drawing.Point(15, 73);
            this.chkKhoiD0.Name = "chkKhoiD0";
            this.chkKhoiD0.Size = new System.Drawing.Size(64, 17);
            this.chkKhoiD0.TabIndex = 1;
            this.chkKhoiD0.Text = "Khối D0";
            this.chkKhoiD0.UseVisualStyleBackColor = true;
            // 
            // chkKhoiD7
            // 
            this.chkKhoiD7.AutoSize = true;
            this.chkKhoiD7.Location = new System.Drawing.Point(15, 96);
            this.chkKhoiD7.Name = "chkKhoiD7";
            this.chkKhoiD7.Size = new System.Drawing.Size(64, 17);
            this.chkKhoiD7.TabIndex = 1;
            this.chkKhoiD7.Text = "Khối D7";
            this.chkKhoiD7.UseVisualStyleBackColor = true;
            // 
            // chkKhoiB
            // 
            this.chkKhoiB.AutoSize = true;
            this.chkKhoiB.Location = new System.Drawing.Point(15, 119);
            this.chkKhoiB.Name = "chkKhoiB";
            this.chkKhoiB.Size = new System.Drawing.Size(57, 17);
            this.chkKhoiB.TabIndex = 1;
            this.chkKhoiB.Text = "Khối B";
            this.chkKhoiB.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpKhoiThi);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblXem);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.radCo);
            this.Controls.Add(this.grpUuTien);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.grpGioiTinh);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();
            this.grpUuTien.ResumeLayout(false);
            this.grpUuTien.PerformLayout();
            this.grpKhoiThi.ResumeLayout(false);
            this.grpKhoiThi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.CheckBox chkKhoiA;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label lblXem;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.GroupBox grpUuTien;
        private System.Windows.Forms.RadioButton radKhong;
        private System.Windows.Forms.RadioButton radCo;
        private System.Windows.Forms.GroupBox grpKhoiThi;
        private System.Windows.Forms.CheckBox chkKhoiB;
        private System.Windows.Forms.CheckBox chkKhoiD7;
        private System.Windows.Forms.CheckBox chkKhoiD0;
        private System.Windows.Forms.CheckBox chkKhoiA1;
    }
}