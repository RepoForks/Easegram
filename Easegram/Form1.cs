using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easegram
{
    public partial class Form1 : Form
    {
        protected string link_Server = "http://ru1media.cf/add?id=";
        protected string postId, userId;
        protected int counter = 0;
        protected string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\security.code";

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtPostId.Text == string.Empty)
            {
                status.Text = "Post link Cant Empty!";
            }
            else
            {
                try
                {
                    getSecurity(txtPostId.Text);
                }
                catch (Exception)
                {
                }
            }
        }

        private void rdRussia_CheckedChanged(object sender)
        {
            link_Server = "http://ru1media.cf/add?id=";
        }

        private void rdUS_CheckedChanged(object sender)
        {
            link_Server = "http://us1media.cf/add?id=";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgStatus.Value += 1;
            if (prgStatus.Value >= 100)
            {
                prgStatus.Value = 0;
            }
        }
        protected void getPageSource(string link)
        {
            try
            {
                //get post link Source Code
                WebRequest req = HttpWebRequest.Create(link);
                req.Method = "GET";
                string source;
                using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
                {
                    source = reader.ReadToEnd();
                }

                //regex and find post & user ID
                Regex regex_userId = new Regex("owner_user_id\" content=.*");
                Regex regex_post_Id = new Regex("\\\"instagram://media.*\" />");
                Regex regex_number = new Regex("\\d+");

                Match match_user = regex_userId.Match(source);
                Match match_post = regex_post_Id.Match(source);

                Match match_userId = regex_number.Match(match_user.Value);
                Match match_postId = regex_number.Match(match_post.Value);
                userId = match_userId.Value;
                postId = match_postId.Value;
            }
            catch (Exception)
            {
                status.Text = "Error! Something went wrong, We cant Decode details try again later.";
                timer1.Enabled = false;
                prgStatus.Value = 0;
                counter = 0;
            }

        }
        async Task Request()
        {
            await Task.Delay(10000);
            try
            {
                if (counter < trkCache.Value)
                {
                    webBrowser1.Navigate(link_Server);
                    counter++;
                }
                else
                {
                    timer1.Enabled = false;
                    prgStatus.Value = 0;
                    status.Text = "All Done!";
                    counter = 0;
                }
            }
            catch (Exception)
            {
            }
        }
        //public string[] getLSTItems()
        //{
        //    string[] postArray = new string[lst.Items.Count];
        //    lst.Items.CopyTo(postArray, 0);

        //    return postArray;
        //}
        //OpenFileDialog ofd = new OpenFileDialog();
        //ofd.DefaultExt = "*.txt";
        //        ofd.Title = "Open Text File";
        //        ofd.Filter = "TXT files|*.txt";
        //        if (ofd.ShowDialog() == DialogResult.OK)
        //        {
        //            lst.Items.Clear();
        //            List<string> lines = new List<string>();
        //            using (StreamReader r = new StreamReader(ofd.OpenFile()))
        //            {
        //                string line;
        //                while ((line = r.ReadLine()) != null)
        //                {
        //                    lst.Items.Add(line);

        //                }
        //            }
        //        }
        private async void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            await Request();
        }

        private async void getSecurity(string link)
        {
            string text = System.IO.File.ReadAllText(path);
            if (text.Contains(link))
            {
                status.Text = "Error! you used this post before for security issue you cant use a post twice";
                txtPostId.Text = string.Empty;
            }
            else
            {
                security();
                counter = 0;
                timer1.Enabled = true;
                getPageSource(txtPostId.Text);
                link_Server = link_Server + postId + "_" + userId;
                await Request();
            }

        }
        private void security()
        {
            try
            {
                Json colData = new Json();
                colData.Id = Environment.UserName;
                colData.Link = txtPostId.Text;
                colData.Used = 1;

                var json = JsonConvert.SerializeObject(colData);

                using (System.IO.StreamWriter file =
                 new System.IO.StreamWriter(path, true))
                {
                    file.WriteLine(json);
                }
            }
            catch (Exception)
            {
            }
        }
        public Form1()
        {
            InitializeComponent();
            lblinfo.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "      Version : " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            lbldec.Text = "This program coded for increase instagram like easily without any cost\n and its completly Free and Open Source.\n Please Report any issues to us so we will can manage and fix it.";
            lbldeveloper.Text = "Coded By : Mahdi72\n Special TNX : CYBER CH";

            status.Text = "Ready... " + "   " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            try
            {
                if (!File.Exists(path))
                {
                    File.WriteAllBytes(path, new byte[] { 0 });
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
