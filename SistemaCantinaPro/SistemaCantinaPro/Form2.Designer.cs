namespace SistemaCantinaPro
{
    partial class WelcomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lkdClose = new System.Windows.Forms.LinkLabel();
            this.lkdNext = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lkdClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lkdNext, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.89474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.89473F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1115, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lkdClose
            // 
            this.lkdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkdClose.AutoSize = true;
            this.lkdClose.Location = new System.Drawing.Point(1062, 0);
            this.lkdClose.Name = "lkdClose";
            this.lkdClose.Size = new System.Drawing.Size(50, 15);
            this.lkdClose.TabIndex = 8;
            this.lkdClose.TabStop = true;
            this.lkdClose.Text = "Close(x)";
            this.lkdClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkdClose_LinkClicked);
            // 
            // lkdNext
            // 
            this.lkdNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lkdNext.AutoSize = true;
            this.lkdNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lkdNext.Location = new System.Drawing.Point(1055, 593);
            this.lkdNext.Name = "lkdNext";
            this.lkdNext.Size = new System.Drawing.Size(57, 25);
            this.lkdNext.TabIndex = 9;
            this.lkdNext.TabStop = true;
            this.lkdNext.Text = "NEXT";
            this.lkdNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkdNext_LinkClicked);
            // 
            // WelcomeScreen
            // 
            this.AcceptButton = this.lkdNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.lkdClose;
            this.ClientSize = new System.Drawing.Size(1115, 618);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WelcomeScreen";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private LinkLabel lkdClose;
        private LinkLabel lkdNext;
    }
}