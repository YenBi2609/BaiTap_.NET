
namespace QLNS_QLYLUONG
{
    partial class frmTimKiem
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
            this.checkMaPB = new System.Windows.Forms.CheckBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTim3 = new System.Windows.Forms.TextBox();
            this.txtTim4 = new System.Windows.Forms.TextBox();
            this.checkMaNV = new System.Windows.Forms.CheckBox();
            this.checkPC = new System.Windows.Forms.CheckBox();
            this.checkHSL = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboTim1 = new System.Windows.Forms.ComboBox();
            this.dtaGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // checkMaPB
            // 
            this.checkMaPB.AutoSize = true;
            this.checkMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaPB.Location = new System.Drawing.Point(115, 73);
            this.checkMaPB.Name = "checkMaPB";
            this.checkMaPB.Size = new System.Drawing.Size(102, 20);
            this.checkMaPB.TabIndex = 0;
            this.checkMaPB.Text = "Theo Mã PB";
            this.checkMaPB.UseVisualStyleBackColor = true;
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(553, 98);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(91, 36);
            this.btnTK.TabIndex = 1;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTim3
            // 
            this.txtTim3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim3.Location = new System.Drawing.Point(277, 144);
            this.txtTim3.Name = "txtTim3";
            this.txtTim3.Size = new System.Drawing.Size(222, 22);
            this.txtTim3.TabIndex = 2;
            // 
            // txtTim4
            // 
            this.txtTim4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim4.Location = new System.Drawing.Point(277, 180);
            this.txtTim4.Name = "txtTim4";
            this.txtTim4.Size = new System.Drawing.Size(222, 22);
            this.txtTim4.TabIndex = 2;
            // 
            // checkMaNV
            // 
            this.checkMaNV.AutoSize = true;
            this.checkMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaNV.Location = new System.Drawing.Point(115, 108);
            this.checkMaNV.Name = "checkMaNV";
            this.checkMaNV.Size = new System.Drawing.Size(103, 20);
            this.checkMaNV.TabIndex = 0;
            this.checkMaNV.Text = "Theo Mã NV";
            this.checkMaNV.UseVisualStyleBackColor = true;
            // 
            // checkPC
            // 
            this.checkPC.AutoSize = true;
            this.checkPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPC.Location = new System.Drawing.Point(115, 144);
            this.checkPC.Name = "checkPC";
            this.checkPC.Size = new System.Drawing.Size(113, 20);
            this.checkPC.TabIndex = 0;
            this.checkPC.Text = "Theo Phụ Cấp";
            this.checkPC.UseVisualStyleBackColor = true;
            // 
            // checkHSL
            // 
            this.checkHSL.AutoSize = true;
            this.checkHSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHSL.Location = new System.Drawing.Point(115, 180);
            this.checkHSL.Name = "checkHSL";
            this.checkHSL.Size = new System.Drawing.Size(140, 20);
            this.checkHSL.TabIndex = 0;
            this.checkHSL.Text = "Theo Hệ Số Lương";
            this.checkHSL.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(553, 147);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 36);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboTim1
            // 
            this.cboTim1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTim1.FormattingEnabled = true;
            this.cboTim1.Location = new System.Drawing.Point(277, 73);
            this.cboTim1.Name = "cboTim1";
            this.cboTim1.Size = new System.Drawing.Size(222, 21);
            this.cboTim1.TabIndex = 3;
            // 
            // dtaGrid
            // 
            this.dtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGrid.Location = new System.Drawing.Point(60, 238);
            this.dtaGrid.Name = "dtaGrid";
            this.dtaGrid.Size = new System.Drawing.Size(622, 191);
            this.dtaGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "TÌM KIẾM THÔNG TIN";
            // 
            // txtTim2
            // 
            this.txtTim2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTim2.FormattingEnabled = true;
            this.txtTim2.Location = new System.Drawing.Point(278, 110);
            this.txtTim2.Name = "txtTim2";
            this.txtTim2.Size = new System.Drawing.Size(221, 21);
            this.txtTim2.TabIndex = 6;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTim2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtaGrid);
            this.Controls.Add(this.cboTim1);
            this.Controls.Add(this.txtTim4);
            this.Controls.Add(this.txtTim3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.checkHSL);
            this.Controls.Add(this.checkPC);
            this.Controls.Add(this.checkMaNV);
            this.Controls.Add(this.checkMaPB);
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkMaPB;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTim3;
        private System.Windows.Forms.TextBox txtTim4;
        private System.Windows.Forms.CheckBox checkMaNV;
        private System.Windows.Forms.CheckBox checkPC;
        private System.Windows.Forms.CheckBox checkHSL;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboTim1;
        private System.Windows.Forms.DataGridView dtaGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtTim2;
    }
}