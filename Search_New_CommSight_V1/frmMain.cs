using GoogleApi.Entities.Maps.Elevation.Response;
using GoogleApi.Entities.Search.Web.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        private string urlGG = "https://www.google.com/search?num=20&q=";

        private string searchMethod = "";

        HttpClient httpClient;
        HttpClientHandler handler;
        CookieContainer cookie = new CookieContainer();
        public frmMain()
        {
            InitializeComponent();
            IniHttpClient();
        }
        void IniHttpClient()
        {
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
            var NewsList = Regex.Matches(htmlResultGG, @"<div class=""r"">(.*?)</div>", RegexOptions.Singleline );

            int countNews = NewsList.Count;
          
            foreach (var news in NewsList)
            {
                string headline = Regex.Match(news.ToString(), @"""(http.*?)""").Groups[1].ToString();

                string title = Regex.Match(news.ToString(), @"<h3\sclas.*?>(.*?)</h3>").Groups[1].ToString();
                this.Invoke(new Action(() => {
                    txtHtml.Text += headline + "\n" + title + "\n";

                }));
                Thread.Sleep(50);               
            }
        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtHtml.Clear();
            if(txtKeyWord.Text != "")
            {
                Task t = new Task(() => { Crawl(urlGG + txtKeyWord.Text); });
                t.Start();              
            }    
            
            //search();

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
    }
}
