
namespace QuachThiYen_2105
{
    partial class FrmTimKiem3
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
            this.radMaCV = new System.Windows.Forms.RadioButton();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.radMaPB = new System.Windows.Forms.RadioButton();
            this.radTenCV = new System.Windows.Forms.RadioButton();
            this.radTenPB = new System.Windows.Forms.RadioButton();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM CHỨC VỤ, PHÒNG BAN";
            // 
            // radMaCV
            // 
            this.radMaCV.AutoSize = true;
            this.radMaCV.Checked = true;
            this.radMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaCV.Location = new System.Drawing.Point(92, 94);
            this.radMaCV.Name = "radMaCV";
            this.radMaCV.Size = new System.Drawing.Size(111, 24);
            this.radMaCV.TabIndex = 1;
            this.radMaCV.TabStop = true;
            this.radMaCV.Text = "Mã chức vụ:";
            this.radMaCV.UseVisualStyleBackColor = true;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(231, 97);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(259, 20);
            this.txtMaCV.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(569, 117);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(92, 243);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(460, 140);
            this.dataGrid.TabIndex = 5;
            // 
            // radMaPB
            // 
            this.radMaPB.AutoSize = true;
            this.radMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaPB.Location = new System.Drawing.Point(92, 159);
            this.radMaPB.Name = "radMaPB";
            this.radMaPB.Size = new System.Drawing.Size(133, 24);
            this.radMaPB.TabIndex = 1;
            this.radMaPB.Text = "Mã phòng ban:";
            this.radMaPB.UseVisualStyleBackColor = true;
            // 
            // radTenCV
            // 
            this.radTenCV.AutoSize = true;
            this.radTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenCV.Location = new System.Drawing.Point(92, 125);
            this.radTenCV.Name = "radTenCV";
            this.radTenCV.Size = new System.Drawing.Size(116, 24);
            this.radTenCV.TabIndex = 1;
            this.radTenCV.Text = "Tên chức vụ:";
            this.radTenCV.UseVisualStyleBackColor = true;
            // 
            // radTenPB
            // 
            this.radTenPB.AutoSize = true;
            this.radTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenPB.Location = new System.Drawing.Point(92, 193);
            this.radTenPB.Name = "radTenPB";
            this.radTenPB.Size = new System.Drawing.Size(138, 24);
            this.radTenPB.TabIndex = 1;
            this.radTenPB.Text = "Tên phòng ban:";
            this.radTenPB.UseVisualStyleBackColor = true;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(231, 127);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(259, 20);
            this.txtTenCV.TabIndex = 2;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(231, 159);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(259, 20);
            this.txtMaPB.TabIndex = 2;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(231, 193);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(259, 20);
            this.txtTenPB.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(569, 193);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmTimKiem3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.radTenCV);
            this.Controls.Add(this.radTenPB);
            this.Controls.Add(this.radMaPB);
            this.Controls.Add(this.radMaCV);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimKiem3";
            this.Text = "FrmTimKiem3";
            this.Load += new System.EventHandler(this.FrmTimKiem3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radMaCV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.RadioButton radMaPB;
        private System.Windows.Forms.RadioButton radTenCV;
        private System.Windows.Forms.RadioButton radTenPB;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Button btnThoat;
    }
}