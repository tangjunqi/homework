using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project14.Crawler;

namespace project14
{
    public partial class Form1 : Form
    {
        public Crawler crawler = new Crawler();
        public Form1()
        {
            InitializeComponent();
            crawler.Inform += Crawler_PageDownloaded;
            textBox1.DataBindings.Add("Text", crawler, "startUrl");
        }
        private void Crawler_PageDownloaded(object o, InformEventArgs e)
        {
            if (listBox1.InvokeRequired)
            {
                Action<InformEventArgs> action = AddResult;
                this.Invoke(action, e);
            }
            else
            {
                AddResult(e);
            }
        }
        private void AddResult(InformEventArgs e)
        {
            if (e.url == null)
            {
                listBox1.Items.Add(e.message);
            }
            else
            {
                listBox1.Items.Add("正在爬取：" + e.url + e.message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            new Thread(crawler.start).Start();
        }
    }
    
}
