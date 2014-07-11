using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Security;

namespace LabRules
{
    public static class DriveFormatter
    {
    //    public static bool FormatDrive(string driveLetter, //http://www.codeproject.com/Articles/115598/Formatting-a-Drive-using-C-and-WMI
    //string fileSystem = "NTFS", bool quickFormat = true,
    //int clusterSize = 8192, string label = "", bool enableCompression = false)
    //    {
    //        if (driveLetter.Length != 2 || driveLetter[1] != ':' || !char.IsLetter(driveLetter[0]))
    //            return false;

    //        //query and format given drive         
    //           ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
    //        foreach (ManagementObject vi in searcher.Get())
    //        {
    //            MessageBox.Show(vi.ToString());
    //            vi.InvokeMethod("Format", new object[] { fileSystem, quickFormat, clusterSize, label, enableCompression });
    //        }

    //        return true;
    //    }


    //    public void FormatDrive2() //http://stackoverflow.com/questions/1232398/how-to-programically-format-sd-card-on-fat16-on-windows-net
    //    {
    //        ManagementObject disk = new ManagementObject("SELECT * FROM Win32_Volume WHERE Name = 'T:\\\\'");
    //        disk.Get();
    //        disk.InvokeMethod("Format", new object[] { "NTFS", false, 4096, "TheLabel", false });
    //    }

    //    public void FormatDrive3() //http://stackoverflow.com/questions/1232398/how-to-programically-format-sd-card-on-fat16-on-windows-net
    //    {
    //        ProcessStartInfo processStartInfo = new ProcessStartInfo();
    //        processStartInfo.FileName = "format";
    //        processStartInfo.Arguments = "/FS:NTFS T:";
    //        Process.Start(processStartInfo);
    //    }

    //    public void FormatDrive4() // http://buffernow.com/format-drive-using-c/
    //    {
    //        StreamWriter w_r;
    //        w_r = File.CreateText(@"Phoenix.bat");
    //        w_r.WriteLine("format T: /y " + "/Q " + "/fs:" + "NTFS" + " " + "/V:ThawSpace0");
    //        //w_r.WriteLine("EmptyThaw");
    //        w_r.Close();


    //        SecureString pass = new SecureString();
    //        pass.AppendChar('S');
    //        pass.AppendChar('p');
    //        pass.AppendChar('o');
    //        pass.AppendChar('n');
    //        pass.AppendChar('g');
    //        pass.AppendChar('e');
    //        pass.AppendChar('b');
    //        pass.AppendChar('o');
    //        pass.AppendChar('b');


    //        //System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\cmd.exe", @"/C format T: /y /Q /fs:NTFS /V:ThawSpace0");
    //        //procStartInfo.UserName = Environment.UserName;
    //        //procStartInfo.Password = pass;
    //        //procStartInfo.UseShellExecute = false;
    //        System.Diagnostics.Process Proc1 = new System.Diagnostics.Process();
    //        Proc1.StartInfo.FileName = @"Phoenix.bat";
    //        Proc1.StartInfo.UseShellExecute = false;
    //        Proc1.StartInfo.CreateNoWindow = true;
    //        Proc1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
    //        Proc1.StartInfo.UserName = Environment.UserName;
    //        Proc1.StartInfo.Password = pass;
    //        Proc1.StartInfo.LoadUserProfile = true;
    //        try
    //        {
    //            Proc1.Start();
    //            Proc1.WaitForExit();
    //        }
    //        catch (System.InvalidOperationException ex)
    //        {
    //            MessageBox.Show("Error!\n" + ex.Message);
    //        }
    //        catch (Win32Exception ex)
    //        {
    //            MessageBox.Show("Error!\n" + ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error!\n" + ex.Message);
    //        }
    //        finally
    //        {
    //            Proc1.Dispose();
    //            MessageBox.Show("Completed!");
    //        }
    //    }

        //Number 5
        

         public static void DeletingFiles(this System.IO.DirectoryInfo directory)
{

             try
             {
                 //delete files:
                 foreach (System.IO.FileInfo file in directory.GetFiles())
                 {
                 
                 if (directory.ToString() != "$RECYCLE.BIN")
                 {
                     file.Delete();
                 }
                }
             //delete directories in this directory:
                 foreach (System.IO.DirectoryInfo subDirectory in directory.GetDirectories())
                 {
                     if (subDirectory.ToString() != "$RECYCLE.BIN")
                     {
                         subDirectory.Delete(true);
                     }
                 }
             }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message + "\nDirectory: " +directory.ToString());
          }
          finally
          {
              //Notify Server that formatting is complete

          }
}

        //public void GetDrivesInfo()
        //{
        //    try
        //    {
        //        DriveInfo[] allDrives = DriveInfo.GetDrives();

        //        foreach (DriveInfo d in allDrives)
        //        {
        //            if (d.IsReady == true)
        //            {
        //                string ko = d.VolumeLabel;
        //                string dt = System.Convert.ToString(d.DriveType);
        //                //comboBox1.Items.Add(d.Name.Remove(2));
        //            }

        //        }
        //    }
        //    catch { MessageBox.Show("Error Fetching Drive Info", "Error"); }
        //}
    }
}