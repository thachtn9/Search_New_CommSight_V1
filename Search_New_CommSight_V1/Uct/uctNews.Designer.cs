namespace Search_New_CommSight_V1.Uct
{
    partial class uctNews
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLineB = new System.Windows.Forms.Panel();
            this.pnlLineL = new System.Windows.Forms.Panel();
            this.txtMedia = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlLineB
            // 
            this.pnlLineB.BackColor = System.Drawing.Color.Silver;
            this.pnlLineB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlLineB.Location = new System.Drawing.Point(0, 74);
            this.pnlLineB.Name = "pnlLineB";
            this.pnlLineB.Size = new System.Drawing.Size(589, 5);
            this.pnlLineB.TabIndex = 2;
            // 
            // pnlLineL
            // 
            this.pnlLineL.BackColor = System.Drawing.Color.Silver;
            this.pnlLineL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLineL.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlLineL.Location = new System.Drawing.Point(0, 0);
            this.pnlLineL.Name = "pnlLineL";
            this.pnlLineL.Size = new System.Drawing.Size(10, 74);
            this.pnlLineL.TabIndex = 3;
            // 
            // txtMedia
            // 
            this.txtMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMedia.ForeColor = System.Drawing.Color.Green;
            this.txtMedia.Location = new System.Drawing.Point(10, 0);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.txtMedia.Size = new System.Drawing.Size(579, 36);
            this.txtMedia.TabIndex = 4;
            this.txtMedia.Text = "Vietnamnet.vn";
            this.txtMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMedia.Click += new System.EventHandler(this.txtUrl_Click);
            this.txtMedia.MouseEnter += new System.EventHandler(this.uctNews_MouseEnter);
            this.txtMedia.MouseLeave += new System.EventHandler(this.uctNews_MouseLeave);
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(171)))));
            this.txtTitle.Location = new System.Drawing.Point(10, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(579, 38);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Text = "asd kjasd adf sd fjsdhf                kjhdf ksdhf";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTitle.Click += new System.EventHandler(this.txtUrl_Click);
            this.txtTitle.MouseEnter += new System.EventHandler(this.uctNews_MouseEnter);
            this.txtTitle.MouseLeave += new System.EventHandler(this.uctNews_MouseLeave);
            // 
            // uctNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.pnlLineL);
            this.Controls.Add(this.pnlLineB);
            this.Name = "uctNews";
            this.Size = new System.Drawing.Size(589, 79);
            this.Load += new System.EventHandler(this.uctNews_Load);
            this.MouseEnter += new System.EventHandler(this.uctNews_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.uctNews_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLineB;
        private System.Windows.Forms.Panel pnlLineL;
        private System.Windows.Forms.Label txtMedia;
        private System.Windows.Forms.Label txtTitle;
    }
}
