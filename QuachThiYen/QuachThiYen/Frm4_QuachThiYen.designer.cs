
namespace QuachThiYen
{
    partial class Frm4_QuachThiYen
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
            this.radMaTS = new System.Windows.Forms.RadioButton();
            this.txtMaTS = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radLoaiTS = new System.Windows.Forms.RadioButton();
            this.txtMaLTS = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // radMaTS
            // 
            this.radMaTS.AutoSize = true;
            this.radMaTS.Checked = true;
            this.radMaTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaTS.Location = new System.Drawing.Point(71, 94);
            this.radMaTS.Name = "radMaTS";
            this.radMaTS.Size = new System.Drawing.Size(126, 20);
            this.radMaTS.TabIndex = 0;
            this.radMaTS.TabStop = true;
            this.radMaTS.Text = "Nhập mã tài sản:";
            this.radMaTS.UseVisualStyleBackColor = true;
            // 
            // txtMaTS
            // 
            this.txtMaTS.Location = new System.Drawing.Point(247, 98);
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.Size = new System.Drawing.Size(306, 20);
            this.txtMaTS.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(622, 88);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 38);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(71, 214);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(547, 165);
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
            // radLoaiTS
            // 
            this.radLoaiTS.AutoSize = true;
            this.radLoaiTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLoaiTS.Location = new System.Drawing.Point(69, 160);
            this.radLoaiTS.Name = "radLoaiTS";
            this.radLoaiTS.Size = new System.Drawing.Size(151, 20);
            this.radLoaiTS.TabIndex = 0;
            this.radLoaiTS.Text = "Nhập mã loại tài sản:";
            this.radLoaiTS.UseVisualStyleBackColor = true;
            // 
            // txtMaLTS
            // 
            this.txtMaLTS.Location = new System.Drawing.Point(246, 161);
            this.txtMaLTS.Name = "txtMaLTS";
            this.txtMaLTS.Size = new System.Drawing.Size(306, 20);
            this.txtMaLTS.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(622, 150);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm4_QuachThiYen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtMaLTS);
            this.Controls.Add(this.txtMaTS);
            this.Controls.Add(this.radLoaiTS);
            this.Controls.Add(this.radMaTS);
            this.Name = "Frm4_QuachThiYen";
            this.Text = "Form Tìm Kiếm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radMaTS;
        private System.Windows.Forms.TextBox txtMaTS;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radLoaiTS;
        private System.Windows.Forms.TextBox txtMaLTS;
        private System.Windows.Forms.Button btnThoat;
    }
}