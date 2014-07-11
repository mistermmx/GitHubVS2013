using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRules
{
   public class Command
   {

       private static string[] Commands =
       {
           "Shutdown",
           "Reboot"
       };

           public static string Reboot()
        {
            return Commands[0];
        }

        public static string Shutdown()
        {
            return "Shutdown";
        }

        public static string FormatTDrive()
        {
            return "FormatTDrive";
        }

        public static string OpenChat()
        {
            return "OpenChat";
        }

        public static string SendMessage()
        {
            return "SendMessage";
        }

        public static string MountNetworkDrive()
        {
            return "MountNetworkDrive";
        }

        public static string UnmountNetworkDrive()
        {
            return "UnmountNetworkDrive";
        }
    }
}
