
namespace _11185711_QuachThiYen_3
{
    partial class Frm3_QuachThiYen
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.loaiTS = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÁOCÁOTÀISẢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loaiTS,
            this.timKiem,
            this.bÁOCÁOTÀISẢNToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // loaiTS
            // 
            this.loaiTS.Name = "loaiTS";
            this.loaiTS.Size = new System.Drawing.Size(90, 20);
            this.loaiTS.Text = "LOẠI TÀI SẢN";
            this.loaiTS.Click += new System.EventHandler(this.loaiTS_Click);
            // 
            // timKiem
            // 
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(175, 20);
            this.timKiem.Text = "TÌM KIẾM TÀI SẢN SỬA CHỮA";
            this.timKiem.Click += new System.EventHandler(this.timKiem_Click);
            // 
            // bÁOCÁOTÀISẢNToolStripMenuItem
            // 
            this.bÁOCÁOTÀISẢNToolStripMenuItem.Name = "bÁOCÁOTÀISẢNToolStripMenuItem";
            this.bÁOCÁOTÀISẢNToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.bÁOCÁOTÀISẢNToolStripMenuItem.Text = "BÁO CÁO TÀI SẢN";
            this.bÁOCÁOTÀISẢNToolStripMenuItem.Click += new System.EventHandler(this.bÁOCÁOTÀISẢNToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Frm3_QuachThiYen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Frm3_QuachThiYen";
            this.Text = "Form Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm3_QuachThiYen_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem loaiTS;
        private System.Windows.Forms.ToolStripMenuItem timKiem;
        private System.Windows.Forms.ToolStripMenuItem bÁOCÁOTÀISẢNToolStripMenuItem;
    }
}



