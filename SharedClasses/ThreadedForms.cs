using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LabRules
{
    public static class ThreadedForms
    {


        public static void AppendToTextBox(TextBox _textbox, string _text)//Make controls on forms thread-safe
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                _textbox.Text += _text;
            });

            _textbox.Invoke(invoker);

            }//End of AppendToTextBox()

        public static void AddClientToGridView(DataGridView _gridView, string _clientName)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                _gridView.Rows[0].Cells[0].Value = "Some Text!";
                
            });

            _gridView.Invoke(invoker);

        }//End of AddClientToGridView()
        


    }//End of ThreadedForms
}//End of Namespace