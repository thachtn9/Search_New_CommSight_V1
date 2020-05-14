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
        private string media;
        private string titel;
        private string url;
       

        public event ClickNewsEventHandler News_Click;
        public uctNews()
        {
            InitializeComponent();
        }

        public uctNews(string titel, string url)
        {
            InitializeComponent();
            this.titel = titel;
            this.url = url;
            
        }              

        private void uctNews_Load(object sender, EventArgs e)
        {
            getMedia();
            txtMedia.Text = media;
            txtTitle.Text = titel;
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
    }
}
