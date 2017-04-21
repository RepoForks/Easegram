namespace Easegram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FlatSkin = new FlatUI.FormSkin();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.prgStatus = new FlatUI.FlatProgressBar();
            this.txtPostId = new FlatUI.FlatTextBox();
            this.trkCache = new FlatUI.FlatTrackBar();
            this.rdRussia = new FlatUI.FlatRadioButton();
            this.btnStart = new FlatUI.FlatButton();
            this.rdUS = new FlatUI.FlatRadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbldeveloper = new FlatUI.FlatLabel();
            this.lbldec = new FlatUI.FlatLabel();
            this.lblinfo = new FlatUI.FlatLabel();
            this.status = new FlatUI.FlatStatusBar();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FlatSkin.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlatSkin
            // 
            this.FlatSkin.BackColor = System.Drawing.Color.White;
            this.FlatSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.FlatSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.FlatSkin.Controls.Add(this.flatTabControl1);
            this.FlatSkin.Controls.Add(this.status);
            this.FlatSkin.Controls.Add(this.flatClose1);
            this.FlatSkin.Controls.Add(this.flatMini1);
            this.FlatSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlatSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.FlatSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FlatSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.FlatSkin.HeaderMaximize = false;
            this.FlatSkin.Location = new System.Drawing.Point(0, 0);
            this.FlatSkin.Name = "FlatSkin";
            this.FlatSkin.Size = new System.Drawing.Size(704, 401);
            this.FlatSkin.TabIndex = 0;
            this.FlatSkin.Text = "Easegram";
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 46);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(704, 332);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.flatLabel1);
            this.tabPage1.Controls.Add(this.flatLabel2);
            this.tabPage1.Controls.Add(this.prgStatus);
            this.tabPage1.Controls.Add(this.txtPostId);
            this.tabPage1.Controls.Add(this.trkCache);
            this.tabPage1.Controls.Add(this.rdRussia);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.rdUS);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(519, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(77, 67);
            this.webBrowser1.TabIndex = 16;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(9, 23);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(60, 19);
            this.flatLabel1.TabIndex = 10;
            this.flatLabel1.Text = "Post link";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(9, 110);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(73, 19);
            this.flatLabel2.TabIndex = 10;
            this.flatLabel2.Text = "Cache Size";
            // 
            // prgStatus
            // 
            this.prgStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.prgStatus.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.prgStatus.Location = new System.Drawing.Point(13, 216);
            this.prgStatus.Maximum = 100;
            this.prgStatus.Name = "prgStatus";
            this.prgStatus.Pattern = true;
            this.prgStatus.PercentSign = true;
            this.prgStatus.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.prgStatus.ShowBalloon = true;
            this.prgStatus.Size = new System.Drawing.Size(669, 42);
            this.prgStatus.TabIndex = 15;
            this.prgStatus.Value = 0;
            // 
            // txtPostId
            // 
            this.txtPostId.BackColor = System.Drawing.Color.Transparent;
            this.txtPostId.FocusOnHover = false;
            this.txtPostId.Location = new System.Drawing.Point(105, 16);
            this.txtPostId.MaxLength = 32767;
            this.txtPostId.Multiline = false;
            this.txtPostId.Name = "txtPostId";
            this.txtPostId.ReadOnly = false;
            this.txtPostId.Size = new System.Drawing.Size(369, 34);
            this.txtPostId.TabIndex = 11;
            this.txtPostId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPostId.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPostId.UseSystemPasswordChar = false;
            // 
            // trkCache
            // 
            this.trkCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.trkCache.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.trkCache.Location = new System.Drawing.Point(105, 110);
            this.trkCache.Maximum = 20;
            this.trkCache.Minimum = 0;
            this.trkCache.Name = "trkCache";
            this.trkCache.ShowValue = true;
            this.trkCache.Size = new System.Drawing.Size(369, 23);
            this.trkCache.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.trkCache.TabIndex = 14;
            this.trkCache.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.trkCache.Value = 5;
            // 
            // rdRussia
            // 
            this.rdRussia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.rdRussia.Checked = true;
            this.rdRussia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdRussia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdRussia.Location = new System.Drawing.Point(13, 65);
            this.rdRussia.Name = "rdRussia";
            this.rdRussia.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.rdRussia.Size = new System.Drawing.Size(139, 22);
            this.rdRussia.TabIndex = 12;
            this.rdRussia.Text = "Server Russia";
            this.rdRussia.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.rdRussia_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStart.Location = new System.Drawing.Point(105, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Rounded = true;
            this.btnStart.Size = new System.Drawing.Size(369, 32);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdUS
            // 
            this.rdUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.rdUS.Checked = false;
            this.rdUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdUS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdUS.Location = new System.Drawing.Point(171, 65);
            this.rdUS.Name = "rdUS";
            this.rdUS.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.rdUS.Size = new System.Drawing.Size(131, 22);
            this.rdUS.TabIndex = 12;
            this.rdUS.Text = "Server USA";
            this.rdUS.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.rdUS_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.lbldeveloper);
            this.tabPage2.Controls.Add(this.lbldec);
            this.tabPage2.Controls.Add(this.lblinfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            // 
            // lbldeveloper
            // 
            this.lbldeveloper.AutoSize = true;
            this.lbldeveloper.BackColor = System.Drawing.Color.Transparent;
            this.lbldeveloper.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbldeveloper.ForeColor = System.Drawing.Color.White;
            this.lbldeveloper.Location = new System.Drawing.Point(9, 107);
            this.lbldeveloper.Name = "lbldeveloper";
            this.lbldeveloper.Size = new System.Drawing.Size(44, 19);
            this.lbldeveloper.TabIndex = 0;
            this.lbldeveloper.Text = "lbldec";
            // 
            // lbldec
            // 
            this.lbldec.AutoSize = true;
            this.lbldec.BackColor = System.Drawing.Color.Transparent;
            this.lbldec.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbldec.ForeColor = System.Drawing.Color.White;
            this.lbldec.Location = new System.Drawing.Point(9, 50);
            this.lbldec.Name = "lbldec";
            this.lbldec.Size = new System.Drawing.Size(44, 19);
            this.lbldec.TabIndex = 0;
            this.lbldec.Text = "lbldec";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblinfo.ForeColor = System.Drawing.Color.White;
            this.lblinfo.Location = new System.Drawing.Point(9, 16);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(68, 19);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "flatLabel3";
            // 
            // status
            // 
            this.status.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(0, 378);
            this.status.Name = "status";
            this.status.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.status.ShowTimeDate = false;
            this.status.Size = new System.Drawing.Size(704, 23);
            this.status.TabIndex = 9;
            this.status.TextColor = System.Drawing.Color.White;
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(668, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 1;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(635, 13);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 401);
            this.Controls.Add(this.FlatSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easegram";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FlatSkin.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin FlatSkin;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatStatusBar status;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatTextBox txtPostId;
        private FlatUI.FlatRadioButton rdUS;
        private FlatUI.FlatRadioButton rdRussia;
        private FlatUI.FlatButton btnStart;
        private FlatUI.FlatTrackBar trkCache;
        private FlatUI.FlatProgressBar prgStatus;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private FlatUI.FlatLabel lblinfo;
        private FlatUI.FlatLabel lbldec;
        private FlatUI.FlatLabel lbldeveloper;
    }
}

