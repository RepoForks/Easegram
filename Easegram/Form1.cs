using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easegram
{
    public partial class Form1 : Form
    {
        protected string link_Server = "http://ru1media.cf/add?id=";
        protected string postId, userId;
        protected int counter = 0;

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (txtPostId.Text == string.Empty)
            {
                status.Text = "Post link Cant Empty!";
            }
            else
            {
                try
                {
                    counter = 0;
                    timer1.Enabled = true;
                    getPageSource(txtPostId.Text);
                    link_Server = link_Server + postId + "_" + userId;
                    await Request();
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
            if (Environment.UserInteractive)
            {
                await Request();
            }
            else
            {
                await RequestCMD();
            }
        }
       
        public Form1()
        {
            InitializeComponent();
            lblinfo.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "      Version : " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            lbldec.Text = "This program coded for increase instagram like easily without any cost\n and its completly Free and Open Source.\n Please Report any issues to us so we will can manage and fix it.";
            lbldeveloper.Text = "Coded By : Mahdi72\n Special TNX : CYBER CH";

            status.Text = "Ready... " + "   " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }
#region Command Line
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        protected int req = 1;
        protected string post = string.Empty;

        public Form1(string[] args)
        {
            InitializeComponent();
            AttachConsole(ATTACH_PARENT_PROCESS);
            
            if (args.Length > 0 & args.Contains("-h") || !args.Contains("-r"))
            {
                help();
            }
            else
            {
                req =Convert.ToInt32(args[1]);
                post = args[3].ToString().Trim();
                if (req > 0 & req < 11)
                {
                    StartCMD();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("   Error! -r must be between 1 and 10 ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            if (args.Contains("-a"))
            {
                about();
            }
        }
        private async void StartCMD()
        {
            start();
            counter = 0;
            getPageSource(post);
            link_Server = link_Server + postId + "_" + userId;
            await RequestCMD();

        }
        async Task RequestCMD()
        {
            await Task.Delay(10000);
            try
            {
                if (counter < req)
                {
                    webBrowser1.Navigate(link_Server);
                    counter++;
                }
                else
                {
                    counter = 0;
                }
            }
            catch (Exception)
            {
            }
        }
        void start()
        {
            Console.Clear();
            if (counter < req)
            {
                for (int i = 0; i < 101; i++)
                {
                    Thread.Sleep(100);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("|");
                    Console.Title = "Sending requests %" + i + "  Conter : " + counter;
                    if (i>=100)
                    {
                        i = 0;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                SendKeys.SendWait("{enter}");
                Console.WriteLine("  we sent likes to your post");
                Console.Title = "Easegram Command Line tool ";
            }
        }
        void about()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "Easegram Command Line tool ";
            Console.WriteLine("Easegram Command Line tool  CMT Version : {0}  GUI Version : {1}\n", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version, FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion);
            Console.WriteLine("Easegram Coded by ---> Mahdi72   |  Special Thanx ---> CYBER CH & Saleh");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Easegram, Easy on Instagram. Get rest and catch unlimited likes on your posts.\n");
            Console.ForegroundColor = ConsoleColor.White;
            SendKeys.SendWait("{enter}");

        }
        void help()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "Easegram Command Line tool\n ";
            Console.WriteLine("\nThis is from the main program" );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Easegram by /u/Mahdi72" );
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Easegram, Easy on Instagram. Get rest and catch unlimited likes on your posts.\n" );
            Console.WriteLine("You can modify its behaviour by using the following parameters when launching the program:\n" );
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  -a        | about Easegram version and programmer." );
            Console.WriteLine("  -h        | Displays this help message." );
            Console.WriteLine("  -r        | for set number of request per 10second.(Min-> 1 ; Max-> 10) ");
            Console.WriteLine("  -p        | instagram post link. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  example usage -->   Easegram.exe -r 8 -p https://www.instagram.com/p/BSivaAQl8rE/ ");
            Console.ForegroundColor = ConsoleColor.White;
            SendKeys.SendWait("{enter}");
        }
#endregion
    }
}
