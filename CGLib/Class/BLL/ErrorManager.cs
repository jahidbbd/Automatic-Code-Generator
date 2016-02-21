//-----------------------------------------------------------------------
// Error Manager Class for writting error in the error log
// Developed by Abdullah Al-Muzahid
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using Microsoft.VisualBasic;

namespace AutomaticCodeGenerator
{
    public class ErrorManager
    {
        #region Constructor & Destructor
        public ErrorManager()
        {
            // TODO: Add constructor logic here
        }
        #endregion

        #region Function
        public void WriteError([System.Runtime.InteropServices.OptionalAttribute, System.Runtime.InteropServices.DefaultParameterValueAttribute("")]  // ERROR: Optional parameters aren't supported in C#
                                string ErrorNumber, [System.Runtime.InteropServices.OptionalAttribute, System.Runtime.InteropServices.DefaultParameterValueAttribute("")]  // ERROR: Optional parameters aren't supported in C#
                                string ErrorMessage, [System.Runtime.InteropServices.OptionalAttribute, System.Runtime.InteropServices.DefaultParameterValueAttribute("")]  // ERROR: Optional parameters aren't supported in C#
                                string ErrorSource, [System.Runtime.InteropServices.OptionalAttribute, System.Runtime.InteropServices.DefaultParameterValueAttribute("")]  // ERROR: Optional parameters aren't supported in C#
                                string ErrorStackTrace)
        {

            try
            {
                //string path = My.Application.Info.DirectoryPath + "\\AppLog.txt";
                //string newPath = My.Application.Info.DirectoryPath + "\\AppLog " + Today.Day + "-" + Today.Month + "-" + Today.Year + " " + Now.Hour + " " + Now.Minute + ".txt";
                string path = Application.StartupPath + "\\ErrorLog.txt";
                string newPath = Application.StartupPath + "\\ErrorLog " + System.DateTime.Now.Day + "-" + System.DateTime.Now.Month + "-" + System.DateTime.Now.Year + " " + System.DateTime.Now.Hour + " " + System.DateTime.Now.Minute + ".txt";


                if (File.Exists(path) == true)
                {
                    double size = 0;
                    //File.Create(path)
                    System.IO.FileInfo infoReader = new FileInfo(path); //default(System.IO.FileInfo);
                    //infoReader = null;// My.Computer.FileSystem.GetFileInfo(path);
                    if (infoReader != null)
                    {
                        size = infoReader.Length / 1024;
                    }
                    else
                    {
                        size = 0;
                    }
                    if (size > 704)
                    {
                        try
                        {
                            File.Move(path, newPath);
                        }
                        catch (IOException ex)
                        {

                        }
                        catch (Exception ex)
                        {


                        }
                    }
                }

                using (StreamWriter w = File.AppendText(path))
                {
                    w.Write("@" + "Log Entry : ");
                    w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                    w.WriteLine("Error# :{0}", ErrorNumber);
                    w.WriteLine("Message :{0}", ErrorMessage);
                    w.WriteLine("Source :{0}", ErrorSource);
                    w.WriteLine("StackTrace :{0}", ErrorStackTrace);
                    w.Flush();
                    w.Close();
                }
            }
            catch (IOException ex)
            {
                //MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public string sqlErrorCollection(int errorNumber)
        {
            string errmsg = null;
            if (errorNumber == 18452)
            {
                errmsg = "Configure your database information";
            }
            else if (errorNumber == 4060)
            {
                errmsg = "Check your database name";
            }
            else if (errorNumber == 18456)
            {
                errmsg = "User name or password doesn't match";
            }
            else if (errorNumber == 53)
            {
                errmsg = "Check server name or your network connectivity";
            }
            else if (errorNumber == 2627)
            {
                errmsg = "Can not insert duplicate value";
            }
            else if (errorNumber == 2812)
            {
                errmsg = "Your database information may not correct";
            }
            else if (errorNumber == 8146)
            {
                errmsg = "Check your database information";
            }
            else if (errorNumber == 2601)
            {
                //unique key violation
                errmsg = "Duplicate data information";
            }
            else if (errorNumber == 3604)
            {
                //unique key violation
                errmsg = "Duplicate data information";
            }
            else
            {
                errmsg = "SQL Error! Please Contact System administrator";
            }
            return errmsg;
        }
        #endregion
    }
}
