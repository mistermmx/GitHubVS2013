using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using NetworkCommsDotNet;

namespace LabRules
{
    public partial class FrmRules : Form
    {
        public FrmRules()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox = false; //Disables the close button
            cbxLanguage.SelectedIndex = 0;
            //DisableTaskManager();
            Location = new Point(0, 0);
            WindowState = FormWindowState.Maximized; //Keep the window maximized
            MinimumSize = Size;
            MaximumSize = Size;
            txtStudentNo.Focus();
            EnsureFocus();
            focusTimer.Start();
        }

        private void EnsureFocus() //Ensure the window is constantly focussed and on top of other windows
        {
            // this.WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }

        
       

        protected override void WndProc(ref Message message) //Prevent window from moving
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Form1_Form1LostFocus(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        

       

        public void AddToStartup()
        {
            RegistryKey rk = Registry.CurrentUser;
            RegistryKey StartupPath;
            StartupPath = rk.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (StartupPath.GetValue("ProjectName") == null)
            {
                StartupPath.SetValue("ProjectName", Application.ExecutablePath, RegistryValueKind.ExpandString);
            }
        }

        //public void embedSoftware()
        //{
        //    try
        //    {
        //        // Disable Task Manager
        //        string shell = System.Windows.Forms.Application.ExecutablePath;

        //       RegistryKey regKey = Registry.CurrentUser.OpenSubKey(subKey, true).CreateSubKey("System");
        //        regKey.SetValue("DisableTaskMgr", 1);
        //        regKey.Close();
        //        // Change the Local Machine shell executable
        //        regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
        //        regKey.SetValue("Shell", shell, RegistryValueKind.String);
        //        regKey.Close();
        //        // Create the Shell executable Registry entry for Current User
        //        regKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
        //        regKey.SetValue("Shell", shell);
        //        regKey.Close();
        //        MessageBox.Show("Embedding Complete");

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This PC may only be used if the lab rules are accepted", "Lab rules declined",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form1_LostFocus(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Ping Server every 10 seconds
            try
            {
                //PingServer("127.0.0.1:10000");
            }
            finally
            {
            }
        }

        private void cbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxLanguage.SelectedIndex)
            {
                case 0: //English
                {
                    rtxtEnglish.Visible = true;
                    rtxtAfrikaans.Visible = false;
                    chkAccept.Text = "I agree and understand the terms and conditions, and agree to abide by them.";
                    rtxtEnglish.Focus();
                    break;
                }
                case 1: //Afrikaans
                {
                    rtxtEnglish.Visible = false;
                    rtxtAfrikaans.Visible = true;
                    chkAccept.Text =
                        "Ek het die reëls en regulasies gelees en verstaan, en onderneem om hul te gehoorsaam.";
                    rtxtAfrikaans.Focus();
                    break;
                }

                default: //English
                {
                    rtxtEnglish.Visible = true;
                    rtxtAfrikaans.Visible = false;
                    chkAccept.Text = "I agree and understand the terms and conditions, and agree to abide by them.";
                    rtxtEnglish.Focus();

                    break;
                }
            }
        }

        private void txtStudentNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this.button1.Click += new System.EventHandler(this.button1_Click);
                btnOK.PerformClick();
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            FindForm().Focus();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (txtStudentNo.Text.Length < 8)
            {
                EnsureFocus();
            }
        }

        private void rtxtAfrikaans_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void chkAccept_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkAccept.Checked)
            {
                case (true):
                    btnOK.Enabled = true;
                    txtStudentNo.Enabled = true;
                    txtStudentNo.Focus();
                    break;

                case (false):
                    btnOK.Enabled = false;
                    txtStudentNo.Enabled = false;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection("Server=196.254.64.6;Database=LabRules;User Id=LabRules;Password=LabRules32;");
            try
            {
                using (
                    var sqlCommand =
                        new SqlCommand("SELECT COUNT(*) from RegisteredStudents where student_no = @StudentNo", conn))
                {
                    conn.Open();
                    sqlCommand.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text);
                    var userCount = (int) sqlCommand.ExecuteScalar();
                    if (userCount > 0) //User exists and logs in
                    {
                        Hide();
                        //TestDataTransmission();
                        //timer1.Start();

                        //Write Login Entry into Database
                       // LogLoginInfo();

                        //Launch Windows Explorer
                    }
                    else
                        MessageBox.Show(
                            "You are not registered to use the CSI labs. Please go see the Technical Officer.",
                            "Not registered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not connect to server. Is the network cable plugged in correctly?\n\n\nFull error description:\n" +
                    ex.Message, "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}