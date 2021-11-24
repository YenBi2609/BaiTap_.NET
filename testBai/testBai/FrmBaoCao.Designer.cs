
namespace testBai
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
            this.CR = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.txtLoaiTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CR
            // 
            this.CR.ActiveViewIndex = -1;
            this.CR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CR.Cursor = System.Windows.Forms.Cursors.Default;
            this.CR.Location = new System.Drawing.Point(1, 47);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(800, 450);
            this.CR.TabIndex = 0;
            this.CR.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(410, 13);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(134, 23);
            this.btnBaoCao.TabIndex = 1;
            this.btnBaoCao.Text = "Xem báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // txtLoaiTien
            // 
            this.txtLoaiTien.Location = new System.Drawing.Point(247, 12);
            this.txtLoaiTien.Name = "txtLoaiTien";
            this.txtLoaiTien.Size = new System.Drawing.Size(100, 20);
            this.txtLoaiTien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại tiền";
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoaiTien);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.CR);
            this.Name = "FrmBaoCao";
            this.Text = "FrmBaoCao";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CR;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.TextBox txtLoaiTien;
        private System.Windows.Forms.Label label1;
    }
}