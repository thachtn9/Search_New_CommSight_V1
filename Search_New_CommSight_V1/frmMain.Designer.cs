namespace Search_New_CommSight_V1
{
    partial class frmMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRightT = new System.Windows.Forms.Panel();
            this.pnlRightB = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLeftB = new System.Windows.Forms.Panel();
            this.pnlLeftT = new System.Windows.Forms.Panel();
            this.pBarWaitSearch = new AltoControls.SpinningCircles();
            this.txtKeyWord = new AltoControls.AltoTextBox();
            this.btnSearch = new AltoControls.AltoButton();
            this.circularPB1 = new AltoControls.CircularPB();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trBTile = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBTile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlRight);
            this.panel2.Controls.Add(this.pnlLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 466);
            this.panel2.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlRightT);
            this.pnlRight.Controls.Add(this.pnlRightB);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(559, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(521, 466);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlRightT
            // 
            this.pnlRightT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightT.Location = new System.Drawing.Point(0, 0);
            this.pnlRightT.Name = "pnlRightT";
            this.pnlRightT.Size = new System.Drawing.Size(521, 330);
            this.pnlRightT.TabIndex = 1;
            // 
            // pnlRightB
            // 
            this.pnlRightB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRightB.Location = new System.Drawing.Point(0, 330);
            this.pnlRightB.Name = "pnlRightB";
            this.pnlRightB.Size = new System.Drawing.Size(521, 136);
            this.pnlRightB.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlContent);
            this.pnlLeft.Controls.Add(this.pnlLeftB);
            this.pnlLeft.Controls.Add(this.pnlLeftT);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(559, 466);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.AutoSize = true;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 130);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(559, 222);
            this.pnlContent.TabIndex = 6;
            // 
            // pnlLeftB
            // 
            this.pnlLeftB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLeftB.Location = new System.Drawing.Point(0, 352);
            this.pnlLeftB.Name = "pnlLeftB";
            this.pnlLeftB.Size = new System.Drawing.Size(559, 114);
            this.pnlLeftB.TabIndex = 5;
            // 
            // pnlLeftT
            // 
            this.pnlLeftT.Controls.Add(this.pBarWaitSearch);
            this.pnlLeftT.Controls.Add(this.txtKeyWord);
            this.pnlLeftT.Controls.Add(this.btnSearch);
            this.pnlLeftT.Controls.Add(this.circularPB1);
            this.pnlLeftT.Controls.Add(this.button1);
            this.pnlLeftT.Controls.Add(this.lblNum);
            this.pnlLeftT.Controls.Add(this.lblTile);
            this.pnlLeftT.Controls.Add(this.label3);
            this.pnlLeftT.Controls.Add(this.trBTile);
            this.pnlLeftT.Controls.Add(this.label1);
            this.pnlLeftT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftT.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftT.Name = "pnlLeftT";
            this.pnlLeftT.Size = new System.Drawing.Size(559, 130);
            this.pnlLeftT.TabIndex = 3;
            // 
            // pBarWaitSearch
            // 
            this.pBarWaitSearch.BackColor = System.Drawing.Color.Transparent;
            this.pBarWaitSearch.FullTransparent = true;
            this.pBarWaitSearch.Increment = 1F;
            this.pBarWaitSearch.Location = new System.Drawing.Point(338, 64);
            this.pBarWaitSearch.N = 5;
            this.pBarWaitSearch.Name = "pBarWaitSearch";
            this.pBarWaitSearch.Radius = 2.5F;
            this.pBarWaitSearch.Size = new System.Drawing.Size(48, 54);
            this.pBarWaitSearch.TabIndex = 14;
            this.pBarWaitSearch.Text = "spinningCircles1";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.BackColor = System.Drawing.Color.Transparent;
            this.txtKeyWord.Br = System.Drawing.Color.White;
            this.txtKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtKeyWord.ForeColor = System.Drawing.Color.DimGray;
            this.txtKeyWord.Location = new System.Drawing.Point(73, 12);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(428, 33);
            this.txtKeyWord.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnSearch.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Inactive1 = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(401, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(83, 36);
            this.btnSearch.Stroke = false;
            this.btnSearch.StrokeColor = System.Drawing.Color.Gray;
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.Transparency = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // circularPB1
            // 
            this.circularPB1.AllowText = true;
            this.circularPB1.AutomaticFontCalculation = true;
            this.circularPB1.BackColor = System.Drawing.Color.Transparent;
            this.circularPB1.Location = new System.Drawing.Point(262, 64);
            this.circularPB1.MaxValue = 100;
            this.circularPB1.MinimumSize = new System.Drawing.Size(60, 60);
            this.circularPB1.MinValue = 0;
            this.circularPB1.Name = "circularPB1";
            this.circularPB1.ProgressColor = System.Drawing.Color.LightBlue;
            this.circularPB1.Size = new System.Drawing.Size(60, 60);
            this.circularPB1.Stroke = 10;
            this.circularPB1.TabIndex = 0;
            this.circularPB1.Text = "circularPB1";
            this.circularPB1.Transparency = true;
            this.circularPB1.Value = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(517, 96);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(19, 13);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "22";
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Location = new System.Drawing.Point(85, 81);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(33, 13);
            this.lblTile.TabIndex = 6;
            this.lblTile.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exact Ratio";
            // 
            // trBTile
            // 
            this.trBTile.Location = new System.Drawing.Point(124, 58);
            this.trBTile.Name = "trBTile";
            this.trBTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trBTile.Size = new System.Drawing.Size(161, 45);
            this.trBTile.TabIndex = 3;
            this.trBTile.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trBTile.Value = 10;
            this.trBTile.Scroll += new System.EventHandler(this.trBTile_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "KeyWord";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 466);
            this.Controls.Add(this.panel2);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlLeftT.ResumeLayout(false);
            this.pnlLeftT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBTile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftB;
        private System.Windows.Forms.Panel pnlLeftT;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trBTile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlContent;
        private System.Windows.Forms.Panel pnlRightT;
        private System.Windows.Forms.Panel pnlRightB;
        private AltoControls.AltoTextBox txtKeyWord;
        private AltoControls.AltoButton btnSearch;
        private AltoControls.CircularPB circularPB1;
        private AltoControls.SpinningCircles pBarWaitSearch;
        private System.Windows.Forms.Button button1;
    }
}