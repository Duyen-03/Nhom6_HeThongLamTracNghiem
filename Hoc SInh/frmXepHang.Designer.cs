namespace Nhom6_HeThongLamTracNghiem.Hoc_SInh
{
    partial class frmXepHang
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
            this.crvXepHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(775, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "XẾP HẠNG";
            // 
            // crvXepHang
            // 
            this.crvXepHang.ActiveViewIndex = -1;
            this.crvXepHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvXepHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvXepHang.Location = new System.Drawing.Point(4, 179);
            this.crvXepHang.Name = "crvXepHang";
            this.crvXepHang.Size = new System.Drawing.Size(1699, 701);
            this.crvXepHang.TabIndex = 4;
            // 
            // frmXepHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1707, 882);
            this.Controls.Add(this.crvXepHang);
            this.Controls.Add(this.label1);
            this.Name = "frmXepHang";
            this.Text = "frmXepHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvXepHang;
    }
}