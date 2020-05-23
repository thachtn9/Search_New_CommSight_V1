using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Search_New_CommSight_V1.Uct
{
    public delegate void ClickNewsEventHandler(string url);
    public partial class uctNews : UserControl
    {

        public string media { get; set; }
        public string time { get; set; }
        public string titel { get; set; }
        public string url { get; set; }
        public bool is_check { get; set; }

        public event ClickNewsEventHandler News_Click;
        public uctNews()
        {
            InitializeComponent();
        }

        public uctNews(string titel, string time,string url)
        {
            InitializeComponent();
            this.titel = titel;
            this.url = url;
            this.time = time;
            is_check = false;


        }        
        

        private void uctNews_Load(object sender, EventArgs e)
        {
            getMedia();
            txtMedia.Text = media;
            txtTitle.Text = time + titel;
        }

        private void txtUrl_Click(object sender, EventArgs e)
        {
            // ClickNewsEventHandler myArgs = new ClickNewsEventHandler()
            this.News_Click(url);
            // System.Diagnostics.Process.Start(txtUrl.Text);
        }

        private void getMedia()
        {
            string media = string.Empty;
            if (!url.Equals(""))
            {
                media = Regex.Match(url.ToString(), @"//(.*?)/").Groups[1].ToString();
            }
            this.media = media;
        }

        private void uctNews_MouseEnter(object sender, EventArgs e)
        {
            pnlLineL.BackColor = pnlLineB.BackColor= Color.FromArgb(44, 124, 228);  
        }

        private void uctNews_MouseLeave(object sender, EventArgs e)
        {
            pnlLineL.BackColor = pnlLineB.BackColor = Color.Silver;
        }

        private void chkChoose_CheckedChanged(object sender, EventArgs e)
        {
            is_check = chkChoose.Checked;
        }
    }
}
