using System;
using System.IO;

namespace Calculator3
{
    class logService
    {
        public static string createLog()
        {
            string time = Convert.ToString(DateTime.Now);
            string time2 = time.Replace("/", "-");
            string time3 = time2.Replace(" ","_");
            string time4 = time3.Replace(":", "-");
            string logFile = "C:\\Users\\" + Environment.UserName + "\\TheDarkGamer Apps\\Calc3\\Logs\\log-" + time4 + ".txt";
            try
            {
                using(FileStream fsLog = File.Create(logFile))
                {
                    fsLog.Close();    
                }
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("The program could not access the file specified. \nPlease make sure you system has access to C:\\Users\\" + Environment.UserName + "\\TheDarkGamer Apps and every file inside that folder");
            }
            return logFile;
        }
        public static void editLog(byte[] text, string logFile)
        {
            try
            {
                File.WriteAllBytes(logFile, text);
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("The program could not access the file specified. \nPlease make sure you system has access to C:\\Users\\" + Environment.UserName + "\\TheDarkGamer Apps and every file inside that folder");
            }
        }
    }
}
