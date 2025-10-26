namespace Nhom6_HeThongLamTracNghiem
{
    partial class frmHocVienMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocVienMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOnTap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichSu = new System.Windows.Forms.ToolStripMenuItem();
            this.xếpHạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepHang = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 736);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1226, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThi,
            this.mnuOnTap,
            this.mnuLichSu,
            this.mnuXepHang,
            this.mnuDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1226, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(126, 34);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuThi
            // 
            this.mnuThi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuThi.Name = "mnuThi";
            this.mnuThi.Size = new System.Drawing.Size(179, 34);
            this.mnuThi.Text = "Thi trắc nghiệm";
            // 
            // mnuOnTap
            // 
            this.mnuOnTap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuOnTap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuOnTap.Name = "mnuOnTap";
            this.mnuOnTap.Size = new System.Drawing.Size(95, 34);
            this.mnuOnTap.Text = "Ôn tập";
            // 
            // mnuLichSu
            // 
            this.mnuLichSu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLichSu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuLichSu.Name = "mnuLichSu";
            this.mnuLichSu.Size = new System.Drawing.Size(124, 34);
            this.mnuLichSu.Text = "Lịch sử thi";
            // 
            // xếpHạngToolStripMenuItem
            // 
            this.xếpHạngToolStripMenuItem.Name = "xếpHạngToolStripMenuItem";
            this.xếpHạngToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.xếpHạngToolStripMenuItem.Text = "Xếp hạng";
            // 
            // mnuXepHang
            // 
            this.mnuXepHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuXepHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuXepHang.Name = "mnuXepHang";
            this.mnuXepHang.Size = new System.Drawing.Size(121, 34);
            this.mnuXepHang.Text = "Xếp hạng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1226, 698);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmHocVienMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHocVienMain";
            this.Text = "frmHocVienMain";
            this.Load += new System.EventHandler(this.frmHocVienMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThi;
        private System.Windows.Forms.ToolStripMenuItem mnuOnTap;
        private System.Windows.Forms.ToolStripMenuItem mnuLichSu;
        private System.Windows.Forms.ToolStripMenuItem mnuXepHang;
        private System.Windows.Forms.ToolStripMenuItem xếpHạngToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



