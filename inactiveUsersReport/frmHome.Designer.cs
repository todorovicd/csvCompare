namespace inactiveUsersReport
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnCompare = new System.Windows.Forms.Button();
            this.lstBoxGoogle = new System.Windows.Forms.ListBox();
            this.lstBoxAD = new System.Windows.Forms.ListBox();
            this.lblGamReport = new System.Windows.Forms.Label();
            this.lblADReport = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlName = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Bold);
            this.btnCompare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCompare.Location = new System.Drawing.Point(175, 372);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(157, 48);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lstBoxGoogle
            // 
            this.lstBoxGoogle.AllowDrop = true;
            this.lstBoxGoogle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstBoxGoogle.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.lstBoxGoogle.FormattingEnabled = true;
            this.lstBoxGoogle.ItemHeight = 16;
            this.lstBoxGoogle.Location = new System.Drawing.Point(29, 182);
            this.lstBoxGoogle.Name = "lstBoxGoogle";
            this.lstBoxGoogle.Size = new System.Drawing.Size(198, 132);
            this.lstBoxGoogle.TabIndex = 1;
            this.lstBoxGoogle.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstBoxGoogle_DragDrop);
            this.lstBoxGoogle.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstBoxGoogle_DragEnter);
            // 
            // lstBoxAD
            // 
            this.lstBoxAD.AllowDrop = true;
            this.lstBoxAD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstBoxAD.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.lstBoxAD.FormattingEnabled = true;
            this.lstBoxAD.ItemHeight = 16;
            this.lstBoxAD.Location = new System.Drawing.Point(284, 182);
            this.lstBoxAD.Name = "lstBoxAD";
            this.lstBoxAD.Size = new System.Drawing.Size(198, 132);
            this.lstBoxAD.TabIndex = 2;
            this.lstBoxAD.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstBoxAD_DragDrop);
            this.lstBoxAD.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstBoxAD_DragEnter);
            // 
            // lblGamReport
            // 
            this.lblGamReport.AutoSize = true;
            this.lblGamReport.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.lblGamReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGamReport.Location = new System.Drawing.Point(48, 145);
            this.lblGamReport.Name = "lblGamReport";
            this.lblGamReport.Size = new System.Drawing.Size(158, 19);
            this.lblGamReport.TabIndex = 3;
            this.lblGamReport.Text = "GAM Report Here";
            // 
            // lblADReport
            // 
            this.lblADReport.AutoSize = true;
            this.lblADReport.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.lblADReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblADReport.Location = new System.Drawing.Point(315, 145);
            this.lblADReport.Name = "lblADReport";
            this.lblADReport.Size = new System.Drawing.Size(142, 19);
            this.lblADReport.TabIndex = 4;
            this.lblADReport.Text = "AD Report Here";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Schoolbook", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(102, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 31);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Inactive Users Report";
            // 
            // btnCloseHome
            // 
            this.btnCloseHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseHome.Font = new System.Drawing.Font("Century Schoolbook", 8.25F);
            this.btnCloseHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCloseHome.Location = new System.Drawing.Point(470, -1);
            this.btnCloseHome.Name = "btnCloseHome";
            this.btnCloseHome.Size = new System.Drawing.Size(46, 35);
            this.btnCloseHome.TabIndex = 16;
            this.btnCloseHome.Text = "X";
            this.btnCloseHome.UseVisualStyleBackColor = true;
            this.btnCloseHome.Click += new System.EventHandler(this.btnCloseHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlName);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 35);
            this.panel1.TabIndex = 17;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(0, 0);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(472, 35);
            this.pnlName.TabIndex = 3;
            // 
            // frmHome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(515, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseHome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblADReport);
            this.Controls.Add(this.lblGamReport);
            this.Controls.Add(this.lstBoxAD);
            this.Controls.Add(this.lstBoxGoogle);
            this.Controls.Add(this.btnCompare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inactive Users";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.ListBox lstBoxGoogle;
        private System.Windows.Forms.ListBox lstBoxAD;
        private System.Windows.Forms.Label lblGamReport;
        private System.Windows.Forms.Label lblADReport;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCloseHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlName;
    }
}

