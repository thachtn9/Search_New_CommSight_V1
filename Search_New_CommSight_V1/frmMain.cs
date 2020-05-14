using CefSharp.WinForms;
using CefSharp;
using GoogleApi.Entities.Maps.Elevation.Response;
using GoogleApi.Entities.Search.Web.Request;
using Newtonsoft.Json;
using Search_New_CommSight_V1.Uct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace Search_New_CommSight_V1
{
    public partial class frmMain : Form
    {
        private string urlGG = "https://www.google.com/search?filter=0&sort=date&num={0}&q={1}";
        private string searchMethod = "";

        public ChromiumWebBrowser browser;
        HttpClient httpClient;
        HttpClientHandler handler;
        CookieContainer cookie = new CookieContainer();
        private int TiLeTimKiem = 10;
        public frmMain()
        {
            InitializeComponent();
            IniHttpClient();
        }
        void IniHttpClient()
        {
            browser = new ChromiumWebBrowser("https://www.google.com/");
            pnlRightT.Controls.Add(browser);
            httpClient = new HttpClient();
            handler = new HttpClientHandler
            {
                CookieContainer = cookie,
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                AllowAutoRedirect = true,
                UseDefaultCredentials = false
            };

            httpClient = new HttpClient(handler);
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.129 Safari/537.36 ");
            /*
             * Header:
             * - Origin
             * - Host
             * - Referer
             * - :scheme
             * - accept
             * - Accept-Encoding
             * - Accept-Language
             * - User-Argent
             * test GIT 
             */           
        }

        string CrawlDataFromURL(string url)
        {
            string html = "";

            html = WebUtility.HtmlDecode(httpClient.GetStringAsync(url).Result);

            //html = httpClient.PostAsync(url,new StringContent("")).Result.Content.ReadAsStringAsync().Result;

            return html;
        }
        void Crawl(string url)
        {
            string htmlResultGG = CrawlDataFromURL(url);
            float FNum = 0;
            circularPB1.Value = 0;
           var NewsList = Regex.Matches(htmlResultGG, @"<div class=""g"">(.*?)<!--n-->", RegexOptions.Singleline );

            int countNews = NewsList.Count;
          
            foreach (var news in NewsList)
            {
                string url_new = Regex.Match(news.ToString(), @"""(http.*?)""").Groups[1].ToString();

                string title = Regex.Match(news.ToString(), @"<h3\sclas.*?>(.*?)</h3>").Groups[1].ToString();
               
                string times = Regex.Match(news.ToString(), @"<span class=""f"">(.*?)</span>").Groups[1].ToString();
               
                this.Invoke(new Action(() => {
                    // txtHtml.Text += headline + "\n" + title + "\n";
                    if(PercentageString(txtKeyWord.Text, title, (float)TiLeTimKiem))
                    addContent(times+title, url_new);
                    // Phần trăm
                   // FNum += (85 / countNews);
                    //if ( FNum >= 100)
                    ////circularPB1.Value = 99;
                    //{ 
                    //}    
                    //else
                    //    circularPB1.Value = (int)FNum;
                    //circularPB1.Value++;
                    }));

                Thread.Sleep(10);              
            }
            this.Invoke(new Action(() => { pBarWaitSearch.Visible = false; }));
        }

        void Crawl()
        {
            string htmlResultGG = CrawlDataFromURL(urlGG);
            var NewsList = Regex.Matches(htmlResultGG, @"<div class=""g"">(.*?)<!--n-->", RegexOptions.Singleline);

            int countNews = NewsList.Count;

            foreach (var news in NewsList)
            {
                string url_new = Regex.Match(news.ToString(), @"""(http.*?)""").Groups[1].ToString();

                string title = Regex.Match(news.ToString(), @"<h3\sclas.*?>(.*?)</h3>").Groups[1].ToString();

                string times = Regex.Match(news.ToString(), @"<span class=""f"">(.*?)</span>").Groups[1].ToString();
                this.Invoke(new Action(() => {
                    //  txtHtml.Text += headline + "\n" + title + "\n";
                    if (PercentageString(txtKeyWord.Text, title, (float)TiLeTimKiem))
                        addContent(times + title, url_new);
                }));

                Thread.Sleep(100);
            }
            this.Invoke(new Action(() => { pBarWaitSearch.Visible = false; }));
           
        }
        private void addContent(string headline, string title)
        {
            //System.Diagnostics.Process.Start(headline); open url
            uctNews uct = new uctNews(headline, title);
            uct.News_Click += Uct_New_Click;
            //uct.Dock = DockStyle.Top;
            pnlContent.Controls.Add(uct);
            lblNum.Text = pnlContent.Controls.Count.ToString();
        }

        private void Uct_New_Click(string url)
        {
            browser.Load(url);          
            //MessageBox.Show(url); 
        }
      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pBarWaitSearch.Visible = true;
            circularPB1.Value = 0;
          //  pnlContent.SendToBack();

            if (txtKeyWord.Text != "")
            {
                Task t = new Task(() => { Crawl(string.Format(urlGG, "60", txtKeyWord.Text));});
                t.Start();
                //using (frmWaitForm frm = new frmWaitForm(Crawl))
                //{
                //    frm.ShowDialog(this);
                //}    
             
            }
           
            //search();

        }

        private bool PercentageString(string str1, string str2, float per)
        {
            int flag = 0;
            string[] a = str1.Split(' ');
            string[] b = str2.Split(' ');            
            float re =a.Count() * (per / 10); // Tỉ lệ % so với số từ của chuỗi 1 .
            if (a.Count() == 0 || b.Count() == 0)
                return false;
            foreach (string s1 in a)
            {
                foreach (string s2 in b)
                {
                    if(s1 == s2)
                    {
                        flag++;
                    }    
                }
            }    
            return flag>= re ? true:false;
        }

        #region Move Form
        //Global variables;
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        #endregion

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trBTile_Scroll(object sender, EventArgs e)
        {
            TiLeTimKiem = trBTile.Value;
            lblTile.Text = (TiLeTimKiem*10).ToString() +" %";
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
           // SetSilent(webBrowser, true);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pBarWaitSearch.Visible = !pBarWaitSearch.Visible;
        }
    }
}
