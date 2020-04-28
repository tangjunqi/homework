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

namespace project14
{
  public class Crawler
    {
        public delegate void InformEventHandler(object o, InformEventArgs e);
        public class InformEventArgs : EventArgs
        {
            public string url { get; set; }
            public string message { get; set; }
        }

        public event InformEventHandler Inform;

        public int count { get; set; }
        public Hashtable urls { get; set; }
        public Crawler()
        {
            urls = new Hashtable();
            count = 0;
        }

        public void start()
        {
            Inform(this, new InformEventArgs() { url = null, message = "开始爬取" });
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                Inform(this, new InformEventArgs() { url = current, message = "正在爬取中" });
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html, current);//解析,并加入新的链接
                Inform(this, new InformEventArgs() { url = null, message = "结束爬取" });
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, String current)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
                Uri uri = new Uri(current);
                string x = uri.Scheme + "://" + uri.Host;

                if (Regex.IsMatch(strRef, "^[/]"))
                {
                    strRef = x + strRef;
                }
                else
                {
                    strRef = current + "/" + strRef;
                }
            }
        }
    }
}