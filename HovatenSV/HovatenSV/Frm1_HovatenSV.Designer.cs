﻿
namespace HovatenSV
{
    partial class Frm1_HovatenSV
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
            this.dANHMỤCTÀISẢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tÌMKIẾMLOẠITÀISẢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dANHMỤCTÀISẢNToolStripMenuItem,
            this.tÌMKIẾMLOẠITÀISẢNToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // dANHMỤCTÀISẢNToolStripMenuItem
            // 
            this.dANHMỤCTÀISẢNToolStripMenuItem.Name = "dANHMỤCTÀISẢNToolStripMenuItem";
            this.dANHMỤCTÀISẢNToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.dANHMỤCTÀISẢNToolStripMenuItem.Text = "DANH MỤC TÀI SẢN";
            this.dANHMỤCTÀISẢNToolStripMenuItem.Click += new System.EventHandler(this.dANHMỤCTÀISẢNToolStripMenuItem_Click);
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
            // tÌMKIẾMLOẠITÀISẢNToolStripMenuItem
            // 
            this.tÌMKIẾMLOẠITÀISẢNToolStripMenuItem.Name = "tÌMKIẾMLOẠITÀISẢNToolStripMenuItem";
            this.tÌMKIẾMLOẠITÀISẢNToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.tÌMKIẾMLOẠITÀISẢNToolStripMenuItem.Text = "TÌM KIẾM LOẠI TÀI SẢN";
            this.tÌMKIẾMLOẠITÀISẢNToolStripMenuItem.Click += new System.EventHandler(this.tÌMKIẾMLOẠITÀISẢNToolStripMenuItem_Click);
            // 
            // Frm1_HovatenSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Frm1_HovatenSV";
            this.Text = "Frm1_HovatenSV";
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
        private System.Windows.Forms.ToolStripMenuItem dANHMỤCTÀISẢNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tÌMKIẾMLOẠITÀISẢNToolStripMenuItem;
    }
}



