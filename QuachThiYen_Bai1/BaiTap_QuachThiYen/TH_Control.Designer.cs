
namespace BaiTap_QuachThiYen
{
    partial class TH_Control
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
            this.cboTruong = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboNgay = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lstDanhsach1 = new System.Windows.Forms.ListBox();
            this.lstDanhsach2 = new System.Windows.Forms.ListBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboTruong
            // 
            this.cboTruong.FormattingEnabled = true;
            this.cboTruong.Location = new System.Drawing.Point(164, 67);
            this.cboTruong.Name = "cboTruong";
            this.cboTruong.Size = new System.Drawing.Size(210, 21);
            this.cboTruong.TabIndex = 0;
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(227, 113);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(54, 21);
            this.cboThang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thực hành về các Control comboBox và listBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên các Trường:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tháng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Năm:";
            // 
            // cboNgay
            // 
            this.cboNgay.AllowDrop = true;
            this.cboNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgay.FormattingEnabled = true;
            this.cboNgay.Location = new System.Drawing.Point(100, 113);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Size = new System.Drawing.Size(54, 21);
            this.cboNgay.TabIndex = 1;
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(353, 113);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(54, 21);
            this.cboNam.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(332, 200);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Chọn 1 -->";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lstDanhsach1
            // 
            this.lstDanhsach1.FormattingEnabled = true;
            this.lstDanhsach1.Items.AddRange(new object[] {
            "CSDL",
            "CSLT",
            "TRR",
            "GIAI TINH",
            "HE CHUYEN GIA",
            "HE DIEU HANH",
            "LAP TRINH WEB",
            "LAP TRINH HUONG DOI TUONG",
            "LAP TRINH UNG DUNG"});
            this.lstDanhsach1.Location = new System.Drawing.Point(62, 162);
            this.lstDanhsach1.Name = "lstDanhsach1";
            this.lstDanhsach1.Size = new System.Drawing.Size(244, 186);
            this.lstDanhsach1.TabIndex = 4;
            // 
            // lstDanhsach2
            // 
            this.lstDanhsach2.FormattingEnabled = true;
            this.lstDanhsach2.Location = new System.Drawing.Point(481, 162);
            this.lstDanhsach2.Name = "lstDanhsach2";
            this.lstDanhsach2.Size = new System.Drawing.Size(261, 173);
            this.lstDanhsach2.TabIndex = 4;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(332, 229);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Chọn n ->>";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(332, 258);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "<-- Chọn 1";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(332, 287);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "<<- Chọn n";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // TH_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDanhsach2);
            this.Controls.Add(this.lstDanhsach1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNgay);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.cboTruong);
            this.Name = "TH_Control";
            this.Text = "Form bài thực hành";
            this.Load += new System.EventHandler(this.TH_Control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTruong;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNgay;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ListBox lstDanhsach1;
        private System.Windows.Forms.ListBox lstDanhsach2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}