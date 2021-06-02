
namespace QuachThiYen_2105
{
    partial class FrmTimKiem1
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
            this.radMaNV = new System.Windows.Forms.RadioButton();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cboPB = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radPB = new System.Windows.Forms.RadioButton();
            this.radTenNV = new System.Windows.Forms.RadioButton();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radCV = new System.Windows.Forms.RadioButton();
            this.cboCV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // radMaNV
            // 
            this.radMaNV.AutoSize = true;
            this.radMaNV.Checked = true;
            this.radMaNV.Location = new System.Drawing.Point(101, 96);
            this.radMaNV.Name = "radMaNV";
            this.radMaNV.Size = new System.Drawing.Size(89, 17);
            this.radMaNV.TabIndex = 0;
            this.radMaNV.TabStop = true;
            this.radMaNV.Text = "Nhập mã NV:";
            this.radMaNV.UseVisualStyleBackColor = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(213, 96);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(306, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // cboPB
            // 
            this.cboPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPB.FormattingEnabled = true;
            this.cboPB.Location = new System.Drawing.Point(213, 167);
            this.cboPB.Name = "cboPB";
            this.cboPB.Size = new System.Drawing.Size(306, 21);
            this.cboPB.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(598, 126);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(86, 243);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(547, 148);
            this.dataGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "TÌM KIẾM THÔNG TIN";
            // 
            // radPB
            // 
            this.radPB.AutoSize = true;
            this.radPB.Location = new System.Drawing.Point(101, 168);
            this.radPB.Name = "radPB";
            this.radPB.Size = new System.Drawing.Size(71, 17);
            this.radPB.TabIndex = 0;
            this.radPB.Text = "Nhập PB:";
            this.radPB.UseVisualStyleBackColor = true;
            // 
            // radTenNV
            // 
            this.radTenNV.AutoSize = true;
            this.radTenNV.Location = new System.Drawing.Point(101, 132);
            this.radTenNV.Name = "radTenNV";
            this.radTenNV.Size = new System.Drawing.Size(90, 17);
            this.radTenNV.TabIndex = 0;
            this.radTenNV.Text = "Nhập tên NV:";
            this.radTenNV.UseVisualStyleBackColor = true;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(213, 131);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(306, 20);
            this.txtTenNV.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(598, 162);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radCV
            // 
            this.radCV.AutoSize = true;
            this.radCV.Location = new System.Drawing.Point(101, 200);
            this.radCV.Name = "radCV";
            this.radCV.Size = new System.Drawing.Size(71, 17);
            this.radCV.TabIndex = 0;
            this.radCV.Text = "Nhập CV:";
            this.radCV.UseVisualStyleBackColor = true;
            // 
            // cboCV
            // 
            this.cboCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCV.FormattingEnabled = true;
            this.cboCV.Location = new System.Drawing.Point(213, 196);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(306, 21);
            this.cboCV.TabIndex = 2;
            // 
            // FrmTimKiem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboCV);
            this.Controls.Add(this.cboPB);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.radTenNV);
            this.Controls.Add(this.radCV);
            this.Controls.Add(this.radPB);
            this.Controls.Add(this.radMaNV);
            this.Name = "FrmTimKiem1";
            this.Text = "FrmTimKiem1";
            this.Load += new System.EventHandler(this.FrmTimKiem1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cboPB;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radPB;
        private System.Windows.Forms.RadioButton radTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton radCV;
        private System.Windows.Forms.ComboBox cboCV;
    }
}