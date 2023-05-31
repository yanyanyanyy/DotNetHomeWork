using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Project
{
    public partial class CrawlerForm : Form
    {
        private Crawler crawler;

        public CrawlerForm()
        {
            crawler = new Crawler();
            InitializeComponent();
            crawler.PageCrawlFailed += crawler_PageCrawlFailed;
            crawler.PageCrawled += crawler_PageCrawled;
        }
        

        private void crawler_PageCrawled(object sender, PageCrawledEventArgs e)
        {
            // 更新进度条和状态标签
            
            lblStatus.Text = string.Format("正在爬取 {0} \t ({1}/{2})", e.Url, e.CrawledPages, e.TotalPages);
            txtUrl.AppendText(lblStatus.Text + Environment.NewLine);
        }

        private void crawler_PageCrawlFailed(object sender, PageCrawlFailedEventArgs e)
        {
            // 显示错误信息
            txtUrl.AppendText(string.Format("爬取 {0} 失败：{1}{2}", e.Url, e.ErrorMessage, Environment.NewLine));
        }

        private async void btnCrawl_Click(object sender, EventArgs e)
        {
            crawler = new Crawler();
            txtUrl.Text = "";
            lblStatus.Text = "";
            crawler.PageCrawlFailed += crawler_PageCrawlFailed;
            crawler.PageCrawled += crawler_PageCrawled;
            string startUrl = StartUrl.Text.Trim();
            Match match = Regex.Match(startUrl, @"^(?<site>(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)");
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.Count = 0;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = ".(html?|aspx|jsp|php)$|^[^.]*$";
            List<string> links = await crawler.CrawlAsync(startUrl);
            foreach (string link in crawler.visitedUrls)
            {
                txtUrl.AppendText(link + Environment.NewLine);
            }

            lblStatus.Text = "爬取完成";
        }

        
    }
}