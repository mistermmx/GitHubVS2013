using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LabRules
{
    class Hardware
    {
        public string GetHardwareInfo()
        {
        // create management class object

ManagementClass mc = new ManagementClass("Win32_ComputerSystem");

//collection to store all management objects

ManagementObjectCollection moc = mc.GetInstances();
string sInfo = "";
if(moc.Count != 0)

{

    foreach (ManagementObject mo in mc.GetInstances())

    {

        // display general system information

        sInfo += String.Format("\nMachine Make: {0}\nMachine Model: {1}\nSystem Type: {2}\nHost Name: {3}\nLogon User Name: {4}\n",

                          mo["Manufacturer"].ToString(),

                          mo["Model"].ToString(),

                          mo["SystemType"].ToString(),

                          mo["DNSHostName"].ToString(),

                          mo["UserName"].ToString());

    }

} return sInfo;
            
        }
    }
}
