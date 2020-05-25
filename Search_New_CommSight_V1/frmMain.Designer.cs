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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlRightT = new System.Windows.Forms.Panel();
            this.btnGooogle = new System.Windows.Forms.Button();
            this.pnlRightB = new System.Windows.Forms.Panel();
            this.dgvListNews = new System.Windows.Forms.DataGridView();
            this.colHeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMediaTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new AltoControls.AltoButton();
            this.btnAddDataNews = new AltoControls.AltoButton();
            this.btnExport = new AltoControls.AltoButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLeftT = new System.Windows.Forms.Panel();
            this.pBarWaitSearch = new AltoControls.SpinningCircles();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sldNews = new AltoControls.SlideButton();
            this.txtKeyWord = new AltoControls.AltoTextBox();
            this.btnSearch = new AltoControls.AltoButton();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trBTile = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRightT.SuspendLayout();
            this.pnlRightB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNews)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBTile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.pnlRight);
            this.panel2.Controls.Add(this.pnlLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 737);
            this.panel2.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(772, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 737);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.splitter2);
            this.pnlRight.Controls.Add(this.pnlRightT);
            this.pnlRight.Controls.Add(this.pnlRightB);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(772, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(928, 737);
            this.pnlRight.TabIndex = 1;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 483);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(928, 3);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // pnlRightT
            // 
            this.pnlRightT.AutoScroll = true;
            this.pnlRightT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlRightT.Controls.Add(this.btnGooogle);
            this.pnlRightT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightT.Location = new System.Drawing.Point(0, 0);
            this.pnlRightT.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRightT.Name = "pnlRightT";
            this.pnlRightT.Size = new System.Drawing.Size(928, 486);
            this.pnlRightT.TabIndex = 1;
            // 
            // btnGooogle
            // 
            this.btnGooogle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGooogle.BackgroundImage")));
            this.btnGooogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGooogle.Location = new System.Drawing.Point(0, 0);
            this.btnGooogle.Name = "btnGooogle";
            this.btnGooogle.Size = new System.Drawing.Size(45, 46);
            this.btnGooogle.TabIndex = 19;
            this.btnGooogle.UseVisualStyleBackColor = true;
            this.btnGooogle.Click += new System.EventHandler(this.btnGooogle_Click);
            // 
            // pnlRightB
            // 
            this.pnlRightB.Controls.Add(this.dgvListNews);
            this.pnlRightB.Controls.Add(this.panel1);
            this.pnlRightB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRightB.Location = new System.Drawing.Point(0, 486);
            this.pnlRightB.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRightB.Name = "pnlRightB";
            this.pnlRightB.Size = new System.Drawing.Size(928, 251);
            this.pnlRightB.TabIndex = 0;
            // 
            // dgvListNews
            // 
            this.dgvListNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListNews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeadline,
            this.colMediaTitle,
            this.colUrl});
            this.dgvListNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListNews.Location = new System.Drawing.Point(0, 0);
            this.dgvListNews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListNews.Name = "dgvListNews";
            this.dgvListNews.RowTemplate.Height = 28;
            this.dgvListNews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListNews.Size = new System.Drawing.Size(813, 251);
            this.dgvListNews.TabIndex = 1;
            // 
            // colHeadline
            // 
            this.colHeadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHeadline.HeaderText = "Headline";
            this.colHeadline.Name = "colHeadline";
            // 
            // colMediaTitle
            // 
            this.colMediaTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMediaTitle.HeaderText = "MediaTitle";
            this.colMediaTitle.Name = "colMediaTitle";
            // 
            // colUrl
            // 
            this.colUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUrl.HeaderText = "Url";
            this.colUrl.Name = "colUrl";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAddDataNews);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(813, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 251);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnClear.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.Inactive2 = System.Drawing.Color.Gainsboro;
            this.btnClear.Location = new System.Drawing.Point(0, 44);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.btnClear.Radius = 10;
            this.btnClear.Size = new System.Drawing.Size(115, 44);
            this.btnClear.Stroke = false;
            this.btnClear.StrokeColor = System.Drawing.Color.Gray;
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.Transparency = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddDataNews
            // 
            this.btnAddDataNews.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnAddDataNews.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnAddDataNews.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDataNews.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddDataNews.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDataNews.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDataNews.ForeColor = System.Drawing.Color.Black;
            this.btnAddDataNews.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btnAddDataNews.Inactive2 = System.Drawing.Color.LightGray;
            this.btnAddDataNews.Location = new System.Drawing.Point(0, 0);
            this.btnAddDataNews.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDataNews.Name = "btnAddDataNews";
            this.btnAddDataNews.Radius = 10;
            this.btnAddDataNews.Size = new System.Drawing.Size(115, 44);
            this.btnAddDataNews.Stroke = false;
            this.btnAddDataNews.StrokeColor = System.Drawing.Color.Gray;
            this.btnAddDataNews.TabIndex = 15;
            this.btnAddDataNews.Text = "<<<";
            this.btnAddDataNews.Transparency = false;
            this.btnAddDataNews.Click += new System.EventHandler(this.btnAddDataNews_Click);
            // 
            // btnExport
            // 
            this.btnExport.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnExport.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExport.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btnExport.Inactive2 = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(0, 207);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Radius = 10;
            this.btnExport.Size = new System.Drawing.Size(115, 44);
            this.btnExport.Stroke = false;
            this.btnExport.StrokeColor = System.Drawing.Color.Gray;
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.Transparency = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlContent);
            this.pnlLeft.Controls.Add(this.pnlLeftT);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(772, 737);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.AutoSize = true;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContent.Location = new System.Drawing.Point(0, 185);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(0, 552);
            this.pnlContent.TabIndex = 6;
            // 
            // pnlLeftT
            // 
            this.pnlLeftT.Controls.Add(this.pBarWaitSearch);
            this.pnlLeftT.Controls.Add(this.dtpTo);
            this.pnlLeftT.Controls.Add(this.dtpFrom);
            this.pnlLeftT.Controls.Add(this.label5);
            this.pnlLeftT.Controls.Add(this.label4);
            this.pnlLeftT.Controls.Add(this.label2);
            this.pnlLeftT.Controls.Add(this.sldNews);
            this.pnlLeftT.Controls.Add(this.txtKeyWord);
            this.pnlLeftT.Controls.Add(this.btnSearch);
            this.pnlLeftT.Controls.Add(this.lblNum);
            this.pnlLeftT.Controls.Add(this.lblTile);
            this.pnlLeftT.Controls.Add(this.label3);
            this.pnlLeftT.Controls.Add(this.trBTile);
            this.pnlLeftT.Controls.Add(this.label1);
            this.pnlLeftT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftT.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftT.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeftT.Name = "pnlLeftT";
            this.pnlLeftT.Size = new System.Drawing.Size(772, 185);
            this.pnlLeftT.TabIndex = 3;
            // 
            // pBarWaitSearch
            // 
            this.pBarWaitSearch.BackColor = System.Drawing.Color.Transparent;
            this.pBarWaitSearch.FullTransparent = true;
            this.pBarWaitSearch.Increment = 2F;
            this.pBarWaitSearch.Location = new System.Drawing.Point(645, 113);
            this.pBarWaitSearch.N = 5;
            this.pBarWaitSearch.Name = "pBarWaitSearch";
            this.pBarWaitSearch.Radius = 2.5F;
            this.pBarWaitSearch.Size = new System.Drawing.Size(60, 69);
            this.pBarWaitSearch.TabIndex = 7;
            this.pBarWaitSearch.Text = "spinningCircles1";
            this.pBarWaitSearch.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(334, 95);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(226, 22);
            this.dtpTo.TabIndex = 18;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(334, 67);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(226, 22);
            this.dtpFrom.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(292, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(278, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(587, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "News";
            this.label2.Visible = false;
            // 
            // sldNews
            // 
            this.sldNews.BorderColor = System.Drawing.Color.LightGray;
            this.sldNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sldNews.IsOn = true;
            this.sldNews.Location = new System.Drawing.Point(645, 80);
            this.sldNews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sldNews.Name = "sldNews";
            this.sldNews.Size = new System.Drawing.Size(52, 28);
            this.sldNews.TabIndex = 7;
            this.sldNews.Text = "slideButton1";
            this.sldNews.TextEnabled = true;
            this.sldNews.Visible = false;
            this.sldNews.SliderValueChanged += new AltoControls.SlideButton.SliderChangedEventHandler(this.sldNews_SliderValueChanged);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.BackColor = System.Drawing.Color.Transparent;
            this.txtKeyWord.Br = System.Drawing.Color.White;
            this.txtKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtKeyWord.ForeColor = System.Drawing.Color.Black;
            this.txtKeyWord.Location = new System.Drawing.Point(98, 14);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(532, 41);
            this.txtKeyWord.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnSearch.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Inactive2 = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(638, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(110, 44);
            this.btnSearch.Stroke = false;
            this.btnSearch.StrokeColor = System.Drawing.Color.Gray;
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.Transparency = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(719, 138);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 17);
            this.lblNum.TabIndex = 7;
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Location = new System.Drawing.Point(114, 100);
            this.lblTile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(36, 17);
            this.lblTile.TabIndex = 6;
            this.lblTile.Text = "10%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exact Ratio";
            // 
            // trBTile
            // 
            this.trBTile.Location = new System.Drawing.Point(98, 71);
            this.trBTile.Margin = new System.Windows.Forms.Padding(4);
            this.trBTile.Name = "trBTile";
            this.trBTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trBTile.Size = new System.Drawing.Size(171, 56);
            this.trBTile.TabIndex = 3;
            this.trBTile.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trBTile.Value = 1;
            this.trBTile.Scroll += new System.EventHandler(this.trBTile_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KeyWord";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 737);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommSight - Search News - Beta V1 - Dev: TruongNgocThach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRightT.ResumeLayout(false);
            this.pnlRightB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNews)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListNews;
        private AltoControls.AltoButton btnExport;
        private AltoControls.AltoButton btnAddDataNews;
        private System.Windows.Forms.Label label2;
        private AltoControls.SlideButton sldNews;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private AltoControls.AltoButton btnClear;
        private System.Windows.Forms.Splitter splitter2;
        private AltoControls.SpinningCircles pBarWaitSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMediaTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.Button btnGooogle;
    }
}