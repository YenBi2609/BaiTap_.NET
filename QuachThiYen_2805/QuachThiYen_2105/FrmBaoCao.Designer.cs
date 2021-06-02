
namespace QuachThiYen_2105
{
    partial class FrmBaoCao
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
            this.BAOCAO_NV2 = new QuachThiYen_2105.BAOCAO_NV();
            this.BAOCAO_NV1 = new QuachThiYen_2105.BAOCAO_NV();
            this.BAOCAO_NV3 = new QuachThiYen_2105.BAOCAO_NV();
            this.CRV_NhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_NhanVien
            // 
            this.CRV_NhanVien.ActiveViewIndex = -1;
            this.CRV_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_NhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.CRV_NhanVien.Name = "CRV_NhanVien";
            this.CRV_NhanVien.Size = new System.Drawing.Size(800, 450);
            this.CRV_NhanVien.TabIndex = 0;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRV_NhanVien);
            this.Name = "FrmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaoCao";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private BAOCAO_NV BAOCAO_NV1;
        private BAOCAO_NV BAOCAO_NV2;
        private BAOCAO_NV BAOCAO_NV3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_NhanVien;
    }
}