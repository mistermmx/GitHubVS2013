using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LabRules
{
    class DatabaseConection
    {
        SqlConnection conn = new SqlConnection("Server=csi.ufs.ac.za;Database=RIS693_GroblerV;User Id=GroblerV;Password=Spongebob;");
        //protected bool IsStudentRegisteredForLabAccess(string _StudentNo)
        //{
        //    try
        //    {
        //        conn.Open();
        //        using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from users where user_name like @username AND password like @password", sqlConnection))
        //        {
        //            conn.Open();
        //            sqlCommand.Parameters.AddWithValue("@username", Form1.);
        //            sqlCommand.Parameters.AddWithValue("@password", passWord);
        //        if (userCount > 0)
        //            // user exists ....
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }



        //}
        private void LogLoginInfo(string _StudentNo, string _IPAddress)
        {
            var conn = new SqlConnection("Server=196.254.64.6;Database=LabRules;User Id=LabRules;Password=LabRules32;");
            try
            {
                using (var sqlCommand = new SqlCommand("WriteLoginEntry", conn))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    sqlCommand.Parameters.AddWithValue("@stud_number", _StudentNo);
                    sqlCommand.Parameters.AddWithValue("@hostname", SystemInformation.ComputerName);
                    sqlCommand.Parameters.AddWithValue("@ipaddress", _IPAddress);
                    sqlCommand.ExecuteNonQuery();
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
    }
}
