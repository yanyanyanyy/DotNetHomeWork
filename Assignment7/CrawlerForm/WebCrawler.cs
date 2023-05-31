using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
    public class Crawler
    {
        public HashSet<string> visitedUrls = new HashSet<string>();
        public event EventHandler<PageCrawledEventArgs> PageCrawled;
        public event EventHandler<PageCrawlFailedEventArgs> PageCrawlFailed;
        public string HostFilter { get; set; }
        //文件过滤规则
        public string FileFilter { get; set; }
        public int Count { get; set; }
        private readonly object CountLock = new object();
        public async Task<List<string>> CrawlAsync(string url)
        {
            List<string> links = new List<string>();

            
            int totalPages = Count;
            int crawledPages = 0;
            // 如果已经访问过该页面            
            try
            {
                if (visitedUrls.Count >= 20 || visitedUrls.Contains(url)) return links;
                Count++;
                crawledPages = Count;
                Console.WriteLine("" + crawledPages + url);
                links.Add(url);
                visitedUrls.Add(url);
                OnPageCrawled(new PageCrawledEventArgs(url, crawledPages, totalPages));
                // 创建WebClient对象并异步获取网页内容
                WebClient client = new WebClient();
                string html = client.DownloadString(url);
                File.WriteAllText("" + Count, html, Encoding.UTF8);
                // 使用正则表达式匹配所有网址
                Regex regex = new Regex(@"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']",
                    RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(html);
                // 输出所有网址并递归爬取每个链接所指向的页面
                foreach (Match match in matches)
                {

                    string linkUrl = match.Groups["url"].Value;

                    if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;
                    linkUrl = FixUrl(linkUrl, url);//转绝对路径
                                                   //解析出host和file两个部分，进行过滤
                    Match linkUrlMatch = Regex.Match(linkUrl, @"^(?<site>(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)");
                    string host = linkUrlMatch.Groups["host"].Value;
                    string file = linkUrlMatch.Groups["file"].Value;
                    if (host == "" || file == "") continue;
                    if (Regex.IsMatch(file, FileFilter) && Regex.IsMatch(host, HostFilter))
                    {
                        links.AddRange(await CrawlAsync(linkUrl));
                    }
                    
                }
                
                return links;
            }
            catch (Exception ex)
            {
                // 处理WebException异常，例如404错误
                Console.WriteLine("Error: {0}", ex.Message);

                // 引发PageCrawlFailed事件，以便MainWindow类可以显示错误信息
                OnPageCrawlFailed(new PageCrawlFailedEventArgs(url, ex.Message));
            }
            
            return links;
        }

        protected virtual void OnPageCrawled(PageCrawledEventArgs e)
        {
            PageCrawled?.Invoke(this, e);
        }

        protected virtual void OnPageCrawlFailed(PageCrawlFailedEventArgs e)
        {
            PageCrawlFailed?.Invoke(this, e);
        }

        static private string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { //完整路径
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, @"^(?<site>(?<protocal>https?)://(?<host>[\\w\\d.-]+)(:\\d+)?($|/))(\\w+/)*(?<file>[^#?]*)");
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, @"^(?<site>(?<protocal>https?)://(?<host>[\\w\\d.-]+)(:\\d+)?($|/))(\\w+/)*(?<file>[^#?]*)");
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }

    public class PageCrawlFailedEventArgs : EventArgs
    {
        public string Url { get; private set; }
        public string ErrorMessage { get; private set; }

        public PageCrawlFailedEventArgs(string url, string errorMessage)
        {
            Url = url;
            ErrorMessage = errorMessage;
        }
    }

    public class PageCrawledEventArgs : EventArgs
    {
        public string Url { get; private set; }
        public int CrawledPages { get; private set; }
        public int TotalPages { get; private set; }

        public PageCrawledEventArgs(string url, int crawledPages, int totalPages)
        {
            Url = url;
            CrawledPages = crawledPages;
            TotalPages = totalPages;
        }
    }
}