using CefSharp.WinForms;
using Search_New_CommSight_V1.Uct;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Search_New_CommSight_V1.Model;
using OfficeOpenXml;
using OfficeOpenXml.Style;
//using xNet;

namespace Search_New_CommSight_V1
{
    public partial class frmMain : Form
    {
        private string urlGG = "https://www.google.com/search?lr=lang_vi&filter=0&sort=date&num={0}&q={1}{2}";
        private string searchMethod = "";
        List<News> listNews;
            
        public ChromiumWebBrowser browser;
        HttpClient httpClient;
        HttpClientHandler handler;
        CookieContainer cookie = new CookieContainer();
        private int TiLeTimKiem = 10;

        public frmMain()
        {
            InitializeComponent();
            IniHttpClient();
            listNews = new List<News>();
        }
        void IniHttpClient()
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            dtpFrom.Format = DateTimePickerFormat.Custom; dtpFrom.CustomFormat = "dd-MM-yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom; dtpTo.CustomFormat = "dd-MM-yyyy";
            browser = new ChromiumWebBrowser("https://www.google.com/");
            browser.Dock = DockStyle.Fill;
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
            //url = "https://dantri.com.vn/kinh-doanh/tai-san-tang-manh-lo-dien-2-ty-phu-usd-cua-viet-nam-tro-lai-duong-dua-20200523065431103.htm";
            string html = "";
            try { 
          

            html = WebUtility.HtmlDecode(httpClient.GetStringAsync(url).Result);

                //html = httpClient.PostAsync(url,new StringContent("")).Result.Content.ReadAsStringAsync().Result;
            }
            catch (Exception x)
            {
                
            }
            return html;
        }
        void Crawl(string url)
        {
            this.Invoke(new Action(() => { pBarWaitSearch.Visible = true; }));
         
           string htmlResultGG = CrawlDataFromURL(url);
              
            if (htmlResultGG == "")
            { this.Invoke(new Action(() => { pBarWaitSearch.Visible = false; })); return; }

            float FNum = 0;

            var NewsList = Regex.Matches(htmlResultGG, @"<div class=""g"">(.*?)<!--n-->", RegexOptions.Singleline);

            int countNews = NewsList.Count;

            foreach (var news in NewsList)
            {
                string url_new = Regex.Match(news.ToString(), @"""(http.*?)""").Groups[1].ToString();

                string title = Regex.Match(news.ToString(), @"<h3\sclas.*?>(.*?)</h3>").Groups[1].ToString();

                string times = Regex.Match(news.ToString(), @"<span class=""f"">(.*?)</span>").Groups[1].ToString();

                this.Invoke(new Action(() =>
                {
                    // txtHtml.Text += headline + "\n" + title + "\n";
                    if (PercentageString(txtKeyWord.Text, title, (float)TiLeTimKiem))
                        addContent(title, times, url_new);

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
                        addContent(title,times, url_new);
                }));

                Thread.Sleep(100);
            }
            this.Invoke(new Action(() => { pBarWaitSearch.Visible = false; }));
           
        }
        private void addContent(string headline,string time, string title)
        {
            //System.Diagnostics.Process.Start(headline); open url
            uctNews uct = new uctNews(headline, time,title);
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
            try
            {
                lblNum.Text = "";
                string time;
                if (dtpFrom.Value.Equals(dtpTo.Value))
                {
                    time = string.Format("&tbs=cdr%3A1%2Ccd_min%3A{0}%2F{1}%2F{2}%2Ccd_max%3A{3}%2F{4}%2F{5}", dtpFrom.Value.Month, dtpFrom.Value.Day, dtpFrom.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day, dtpTo.Value.Year);

                }
                else time = "&tbs=qdr:d";
               
                pnlContent.Controls.Clear();
                listNews.Clear();
              
             
                //  pnlContent.SendToBack();

                if (txtKeyWord.Text != "")
                {
                    Task t = new Task(() => { Crawl(string.Format(urlGG, "60", txtKeyWord.Text , time )); });
                    t.Start();
                    //using (frmWaitForm frm = new frmWaitForm(Crawl))
                    //{
                    //    frm.ShowDialog(this);
                    //}    

                }
            }catch(Exception x)
            {
                MessageBox.Show("Error not Internet !");
            }
           
            //search();

        }

        private bool PercentageString(string str1, string str2, float per)
        {
            int flag = 0;
            string[] a = str1.Split(' ');
            string[] b = str2.Split(' ');            
            float re =(a.Count() * per) / 10; // Tỉ lệ % so với số từ của chuỗi 1 .
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

        private void btnAddDataNews_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => {
                //  txtHtml.Text += headline + "\n" + title + "\n";
                string headline;
                foreach (uctNews uNews in pnlContent.Controls)
                {
                    if (!uNews.is_check) continue;
                    headline = getHeadlineNews(uNews.url);
                    dgvListNews.Rows.Add(headline == "" ? uNews.titel : headline, uNews.media, uNews.url);
                    uNews.unCheckNewOld();
                }
            }));
           
            
           
        }

        private string getHeadlineNews(string url)
        {
            string htmlNews = CrawlDataFromURL(url);

          
            string strH1 = Regex.Match(htmlNews.ToString(), @"<h1(.*?)>(.*?)<\/h1",RegexOptions.Singleline).Groups[2].ToString().Trim(); // lấy thẻ H1 làm headline.

            if(strH1.IndexOf("class")>0)
            {
                strH1 = "";
            }
            string strHeadline = Regex.Match(htmlNews.ToString(), @"name=['""]description['""](.*?)content=['""](.*?)['""]").Groups[2].ToString();

            return strH1 != "" ? strH1 : strHeadline;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvListNews.Rows.Clear();
        }

        private void sldNews_SliderValueChanged(object sender, EventArgs e)
        {
            dtpTo.Enabled= dtpFrom.Enabled = !sldNews.IsOn;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {            
                string filePath = "";
                // tạo SaveFileDialog để lưu file excel
                SaveFileDialog dialog = new SaveFileDialog();

                // chỉ lọc ra các file có định dạng Excel
                dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

                // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                }

                // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                    return;
                }

                try
                {
                    using (ExcelPackage p = new ExcelPackage())
                    {
                        // đặt tên người tạo file
                        p.Workbook.Properties.Author = "CommSights";

                        // đặt tiêu đề cho file
                        p.Workbook.Properties.Title = "Thống Kê News";

                        //Tạo một sheet để làm việc trên đó
                        p.Workbook.Worksheets.Add("News");

                        // lấy sheet vừa add ra để thao tác
                        ExcelWorksheet ws = p.Workbook.Worksheets[0];

                        // đặt tên cho sheet
                        ws.Name = "News";
                        // fontsize mặc định cho cả sheet
                        ws.Cells.Style.Font.Size = 11;
                        // font family mặc định cho cả sheet
                        ws.Cells.Style.Font.Name = "Calibri";

                        // Tạo danh sách các column header
                        string[] arrColumnHeader = {                                                
                                                "Headline",
                                                "MediaTitle",
                                                "Url"
                };

                        // lấy ra số lượng cột cần dùng dựa vào số lượng header
                        var countColHeader = arrColumnHeader.Count();

                        //// merge các column lại từ column 1 đến số column header
                        //// gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                        //ws.Cells[1, 1].Value = "Thống kê thông tin User Kteam";
                        //ws.Cells[1, 1, 1, countColHeader].Merge = true;
                        //// in đậm
                        //ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                        //// căn giữa
                        //ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                        int colIndex = 1;
                        int rowIndex = 2;

                        //tạo các header từ column header đã tạo từ bên trên
                        foreach (var item in arrColumnHeader)
                        {
                            var cell = ws.Cells[rowIndex, colIndex];

                            //set màu thành gray
                            var fill = cell.Style.Fill;
                            fill.PatternType = ExcelFillStyle.Solid;
                            fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                            //căn chỉnh các border
                            var border = cell.Style.Border;
                            border.Bottom.Style =
                                border.Top.Style =
                                border.Left.Style =
                                border.Right.Style = ExcelBorderStyle.Thin;

                            //gán giá trị
                            cell.Value = item;

                            colIndex++;
                        }

                    // lấy ra danh sách UserInfo từ ItemSource của DataGrid
                    // List<> userList = dgvListNews.ItemsSource.Cast<UserInfo>().ToList();
                    foreach (DataGridViewRow row in dgvListNews.Rows)
                    {
                        int a = dgvListNews.Rows.Count;
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell
                        if (row.Cells["colUrl"].Value == null) continue;
                        ws.Cells[rowIndex, colIndex].Value = row.Cells["colHeadline"].Value;
                        ws.Cells[rowIndex, colIndex++].Hyperlink = new Uri(row.Cells["colUrl"].Value.ToString());
                       
                        ws.Cells[rowIndex, colIndex++].Value = row.Cells["colMediaTitle"].Value;
                       
                      
                        
                        ws.Cells[rowIndex, colIndex++].Value = row.Cells["colUrl"].Value;

                        // lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                        //ws.Cells[rowIndex, colIndex++].Value = item.Birthday.ToShortDateString();

                    }
                   

                        //Lưu file lại
                        Byte[] bin = p.GetAsByteArray();
                        File.WriteAllBytes(filePath, bin);
                    }
                    MessageBox.Show("Xuất excel thành công!");
                }
                catch (Exception EE)
                {
                    MessageBox.Show("Có lỗi khi lưu file!");
                }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnGooogle_Click(object sender, EventArgs e)
        {
            browser.Load("https://www.google.com/");// = new ChromiumWebBrowser("https://www.google.com/");
        }
    }
}
