namespace Easegram
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.thirteenForm1 = new Teen.ThirteenForm();
            this.btnGit = new Teen.ThirteenButton();
            this.thirteenControlBox21 = new Teen.ThirteenControlBox2();
            this.prg = new System.Windows.Forms.ProgressBar();
            this.btn = new Teen.ThirteenButton();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new Teen.ThirteenTextBox();
            this.chk = new Teen.ThirteenCheckBox();
            this.thirteenForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // thirteenForm1
            // 
            this.thirteenForm1.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenForm1.ColorScheme = Teen.ThirteenForm.ColorSchemes.Dark;
            this.thirteenForm1.Controls.Add(this.chk);
            this.thirteenForm1.Controls.Add(this.btnGit);
            this.thirteenForm1.Controls.Add(this.thirteenControlBox21);
            this.thirteenForm1.Controls.Add(this.prg);
            this.thirteenForm1.Controls.Add(this.btn);
            this.thirteenForm1.Controls.Add(this.lbl);
            this.thirteenForm1.Controls.Add(this.label1);
            this.thirteenForm1.Controls.Add(this.txt);
            this.thirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirteenForm1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenForm1.ForeColor = System.Drawing.Color.White;
            this.thirteenForm1.Location = new System.Drawing.Point(0, 0);
            this.thirteenForm1.Name = "thirteenForm1";
            this.thirteenForm1.Size = new System.Drawing.Size(507, 184);
            this.thirteenForm1.TabIndex = 0;
            this.thirteenForm1.Text = "Easegram   Coded By Mahdi72";
            // 
            // btnGit
            // 
            this.btnGit.AccentColor = System.Drawing.Color.DodgerBlue;
            this.btnGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGit.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.btnGit.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.btnGit.ForeColor = System.Drawing.Color.White;
            this.btnGit.Location = new System.Drawing.Point(420, 120);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(75, 23);
            this.btnGit.TabIndex = 5;
            this.btnGit.Text = "GitHub";
            this.btnGit.UseVisualStyleBackColor = false;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // thirteenControlBox21
            // 
            this.thirteenControlBox21.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenControlBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thirteenControlBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenControlBox21.ColorScheme = Teen.ThirteenControlBox2.ColorSchemes.Dark;
            this.thirteenControlBox21.ForeColor = System.Drawing.Color.White;
            this.thirteenControlBox21.Location = new System.Drawing.Point(407, 3);
            this.thirteenControlBox21.Name = "thirteenControlBox21";
            this.thirteenControlBox21.Size = new System.Drawing.Size(100, 25);
            this.thirteenControlBox21.TabIndex = 4;
            this.thirteenControlBox21.Text = "thirteenControlBox21";
            // 
            // prg
            // 
            this.prg.Location = new System.Drawing.Point(15, 149);
            this.prg.Maximum = 200;
            this.prg.Name = "prg";
            this.prg.Size = new System.Drawing.Size(480, 23);
            this.prg.Step = 1;
            this.prg.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.AccentColor = System.Drawing.Color.DodgerBlue;
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.btn.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(141, 97);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(231, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Start";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(249, 127);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(25, 17);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Post link";
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.txt.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(100, 54);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(318, 25);
            this.txt.TabIndex = 0;
            // 
            // chk
            // 
            this.chk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chk.Checked = false;
            this.chk.ColorScheme = Teen.ThirteenCheckBox.ColorSchemes.Dark;
            this.chk.ForeColor = System.Drawing.Color.White;
            this.chk.Location = new System.Drawing.Point(15, 103);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(99, 17);
            this.chk.TabIndex = 6;
            this.chk.Text = "Infinity Loop";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 184);
            this.Controls.Add(this.thirteenForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.thirteenForm1.ResumeLayout(false);
            this.thirteenForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Teen.ThirteenForm thirteenForm1;
        private System.Windows.Forms.Label label1;
        private Teen.ThirteenTextBox txt;
        private Teen.ThirteenButton btn;
        private System.Windows.Forms.ProgressBar prg;
        private System.Windows.Forms.Label lbl;
        private Teen.ThirteenControlBox2 thirteenControlBox21;
        private Teen.ThirteenButton btnGit;
        private Teen.ThirteenCheckBox chk;
    }
}