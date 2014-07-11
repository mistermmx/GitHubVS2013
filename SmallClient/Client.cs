using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace LabRules
{
     class Client
    {
        //Client
        #region Client
        private static readonly Socket _clientSocket = new Socket
                (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public static TextBox _clientTextBox, _clientInputTextBox;
        private const int _PORT = 100;


         

         public string ClientName
         {
             get
             {
                 return  System.Net.Dns.GetHostName();
             }
         }

         public string ClientIpAddress
         {
             get { return _clientSocket.LocalEndPoint.ToString(); }
         }


         public static void ConnectToServer()
        {
            int attempts = 0;

            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    ThreadedForms.AppendToTextBox(_clientTextBox, "Connection attempt " + attempts + "\r\n");
                    _clientSocket.Connect(IPAddress.Loopback, _PORT);
                }
                catch (SocketException)
                {
                    ThreadedForms.AppendToTextBox(_clientTextBox, "Socket Exception");
                }
            }

            ThreadedForms.AppendToTextBox(_clientTextBox, "CLEAR!");
            ThreadedForms.AppendToTextBox(_clientTextBox, "Connected");
        }

        public static void RequestLoop()
        {
            ThreadedForms.AppendToTextBox(_clientTextBox, @"<Type ""exit"" to properly disconnect client>");

            while (true)
            {
                SendRequest();
                ReceiveResponse();
            }
        }

        /// <summary>
        /// Close socket and exit app
        /// </summary>
        public static void Exit()
        {
            SendString("exit"); // Tell the server we are exiting
            _clientSocket.Shutdown(SocketShutdown.Both);
            _clientSocket.Close();
            Environment.Exit(0);
        }

        public static void SendRequest()
        {
            ThreadedForms.AppendToTextBox(_clientTextBox, "Send a request: ");
            string request = _clientInputTextBox.Text;
            SendString(request);

            if (request.ToLower() == "exit")
            {
                Exit();
            }
        }

        /// <summary>
        /// Sends a string to the server with ASCII encoding
        /// </summary>
        public static void SendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        public static void ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = _clientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
            ThreadedForms.AppendToTextBox(_clientTextBox, text + "\r\n");

            try
            {
                //Cannot use switch statement, so using if statements instead
                if (text == Command.FormatTDrive())
                {
                    //DriveFormatter.DeletingFiles();
                    System.IO.DirectoryInfo dInfo = new System.IO.DirectoryInfo(@"T:\");
                    DriveFormatter.DeletingFiles(dInfo);
                }
                if (text == Command.Reboot())
                {
                    //DriveFormatter.Reboot();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Send 'Error' message to server
            }
        }

         public void ReceiveCommand(string _command)
         {
             try
             {
                 //Cannot use switch statement, so using if statements instead
                 if (_command == Command.FormatTDrive())
                 {
                     //DriveFormatter.DeletingFiles();
                     System.IO.DirectoryInfo dInfo = new System.IO.DirectoryInfo(@"T:\");
                     DriveFormatter.DeletingFiles(dInfo);
                 }
                 if (_command == Command.Reboot())
                 {
                     //DriveFormatter.DeletingFiles();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 //Send 'Error' message to server
             }
             finally
             {
                 //Send 'Completed' message to server
             }

         }



         //End of Client
        #endregion

    }
}
