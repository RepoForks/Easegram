using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easegram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            thirteenForm1.Text += "    " + ProductVersion;
        }
        private string _ID;
        private async void btn_Click(object sender, EventArgs e)
        {
            btn.Enabled = false;
            await Request();
        }
        private async Task<string> getPostId()
        {
          await Task.Run(() => {
                WebClient webClient = new WebClient();
                string str = "http://api.instagram.com/oembed?url=";
                string text = webClient.DownloadString(str + txt.Text);
                int num = text.IndexOf(string.Concat(new object[]
                {
                '"',
                "media_id",
                '"',
                ": ",
                '"'
                }));
                int num2 = text.IndexOf(string.Concat(new object[]
                {
                '"',
                ", ",
                '"',
                "provider_name"
                }));
              _ID = text.Substring(num + 13, num2 - (num + 13));
          });
            return _ID;
        }
        async Task Request()
        {
            await Task.Delay(2000);
            try
            {
                WebClient webClient = new WebClient();
                for (int i = 0; i < 200; i++)
                {
                    webClient.DownloadString("http://194.58.115.48/add?id=" + await getPostId());
                    webClient.DownloadString("http://ru2media.cf/add?id=" + await getPostId());
                    prg.Value = i;
                    lbl.Text = i + "%";
                }
                btn.Enabled = true;
                prg.Value = 0;
                lbl.Text = "0%";
            }
            catch (Exception)
            {
            }
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ghost1372/Easegram");
        }
    }
}
