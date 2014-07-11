using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LabRules;

namespace SmallClient
{
    public partial class frmSmallClient : Form
    {
        public frmSmallClient()
        {
            InitializeComponent();
        }

        private void frmSmallClient_Load(object sender, EventArgs e)
        {
            Client._clientTextBox = this.txtClientLive;
            Client._clientInputTextBox = this.txtInput;
            Client.ConnectToServer();
            //NetworkConnection.RequestLoop();
           // NetworkConnection.Exit();

        }


    }
}
