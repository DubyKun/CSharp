using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urls
{
    class Crawler
    {
        public event Action<Crawler> CrawlerStop;
        public event Action<Crawler, string, string> PageDownload;
        private Dictionary<string, bool> urls = new Dictionary<string, bool>();  //所有已下载和待下载URL，key是URL，value表示是否下载成功
        private Queue<string> pending = new Queue<string>();        //待下载队列

        private readonly string urlDetectRegex = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";        //URL解析表达式
        public string HostFilter;  //主机过滤规则
        public string FileFilter;  //文件过滤规则
        public int MaxPage;        //最大下载数量
        public string StartURL;    //起始网址
        public Encoding HtmlEncoding;  //网页编码
        public Dictionary<string, bool> DownloadedPages
        {
            get => urls;
        }


        public Crawler() { MaxPage = 128;HtmlEncoding = Encoding.UTF8; }


        private string DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = urls.Count.ToString();
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }

        private void Parse(string html, string pageUrl)
        {

            var matches = new Regex(urlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = FixUrl(linkUrl, pageUrl);//转绝对路径

                //解析出host和file两个部分，进行过滤
                Match UrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = UrlMatch.Groups["host"].Value;
                string file = UrlMatch.Groups["file"].Value;
                if (file == "") { file = "index.html"; }

                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !urls.ContainsKey(linkUrl))
                {
                    pending.Enqueue(linkUrl);
                    urls.Add(linkUrl, false);
                }
            }
        }


        static private string FixUrl(string url, string baseUrl)
        {

            if (url.Contains("://"))
            {
                return url;
            }else if (url.StartsWith("//"))
            {
                return "http:" + url;
            }else if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(baseUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }else if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = baseUrl.LastIndexOf('/');
                return FixUrl(url, baseUrl.Substring(0, idx));
            }else if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), baseUrl);
            }
            else 
            {
                int end = baseUrl.LastIndexOf("/");
                return baseUrl.Substring(0, end) + "/" + url;
            }


        }
        public void Start()
        {
            urls.Clear();
            pending.Clear();
            pending.Enqueue(StartURL);

            while (urls.Count < MaxPage && pending.Count > 0)
            {
                string url = pending.Dequeue();
                try
                {
                    string html = DownLoad(url);
                    urls[url] = true;
                    PageDownload(this, url, "success");
                    Parse(html, url);//解析,并加入新的链接
                }
                catch (Exception ex)
                {
                    PageDownload(this, url, "  Error:" + ex.Message);
                }
            }
            CrawlerStop(this);
        }
    }
}
