using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urls
{
    public partial class Form1 : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        Crawler crawler = new Crawler();
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = resultBindingSource;
            crawler.PageDownload += Crawler_PageDownload;
            crawler.CrawlerStop += Crawler_CrawlerStop;
        }
        private void Crawler_CrawlerStop(Crawler obj)
        {
            Action action = () => label1.Text = "爬取结束";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            } else
            {
                action();
            }
        }

        private void Crawler_PageDownload(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            crawler.StartURL = textBox1.Text;

            Match match = Regex.Match(crawler.StartURL, Crawler.urlParseRegex);
            if (match.Length == 0) { return; }
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = ".html?$";

            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(crawler.Start);
            thread.Start();
            label1.Text = "爬虫已启动....";
        }
    }
}
