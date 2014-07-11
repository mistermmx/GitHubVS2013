namespace LabRules
{
    partial class FrmRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRules));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAccept = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxtEnglish = new System.Windows.Forms.RichTextBox();
            this.focusTimer = new System.Windows.Forms.Timer(this.components);
            this.rtxtAfrikaans = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.DisplayMember = "1";
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "English (Default)",
            "Afrikaans"});
            this.cbxLanguage.Location = new System.Drawing.Point(86, 55);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbxLanguage.TabIndex = 5;
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chkAccept);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.txtStudentNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 772);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 51);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Format T Drive";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter your student number:";
            // 
            // chkAccept
            // 
            this.chkAccept.AutoSize = true;
            this.chkAccept.Location = new System.Drawing.Point(12, 6);
            this.chkAccept.Name = "chkAccept";
            this.chkAccept.Size = new System.Drawing.Size(413, 17);
            this.chkAccept.TabIndex = 13;
            this.chkAccept.Text = "I have read and understand the terms and conditions, and agree to abide by them.";
            this.chkAccept.UseVisualStyleBackColor = true;
            this.chkAccept.CheckedChanged += new System.EventHandler(this.chkAccept_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(313, 26);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 22);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Enabled = false;
            this.txtStudentNo.Location = new System.Drawing.Point(151, 26);
            this.txtStudentNo.MaxLength = 10;
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(156, 20);
            this.txtStudentNo.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxLanguage);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 100);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(163, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rtxtEnglish
            // 
            this.rtxtEnglish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtEnglish.Location = new System.Drawing.Point(0, 100);
            this.rtxtEnglish.Margin = new System.Windows.Forms.Padding(5);
            this.rtxtEnglish.Name = "rtxtEnglish";
            this.rtxtEnglish.ReadOnly = true;
            this.rtxtEnglish.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtEnglish.Size = new System.Drawing.Size(1061, 672);
            this.rtxtEnglish.TabIndex = 14;
            this.rtxtEnglish.Text = resources.GetString("rtxtEnglish.Text");
            // 
            // focusTimer
            // 
            this.focusTimer.Interval = 1000;
            this.focusTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // rtxtAfrikaans
            // 
            this.rtxtAfrikaans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtAfrikaans.Location = new System.Drawing.Point(0, 100);
            this.rtxtAfrikaans.Name = "rtxtAfrikaans";
            this.rtxtAfrikaans.ReadOnly = true;
            this.rtxtAfrikaans.Size = new System.Drawing.Size(1061, 672);
            this.rtxtAfrikaans.TabIndex = 15;
            this.rtxtAfrikaans.Text = resources.GetString("rtxtAfrikaans.Text");
            this.rtxtAfrikaans.Visible = false;
            this.rtxtAfrikaans.TextChanged += new System.EventHandler(this.rtxtAfrikaans_TextChanged);
            // 
            // FrmRules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1061, 823);
            this.Controls.Add(this.rtxtAfrikaans);
            this.Controls.Add(this.rtxtEnglish);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Rules";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LostFocus += new System.EventHandler(this.Form1_LostFocus);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxtEnglish;
        private System.Windows.Forms.Timer focusTimer;
        private System.Windows.Forms.RichTextBox rtxtAfrikaans;
        private System.Windows.Forms.CheckBox chkAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

