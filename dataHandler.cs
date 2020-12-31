using System;
using System.IO;
using System.Text;

namespace Calculator3
{
    class dataHandler
    {
        public static void Main()
        {
            data(null);
        }
        public static void data(string logFile)
        {
            string user = Environment.UserName;
            string userNew = user.Replace(" ","_");
            string tdgAppFolder = "C:\\Users\\" + user + "\\TheDarkGamer Apps";
            string mainFolder = "C:\\Users\\" + user + "\\TheDarkGamer Apps\\Calc3";
            if (!File.Exists(tdgAppFolder))
            {
                try
                {
                    Directory.CreateDirectory(tdgAppFolder);
                    Directory.CreateDirectory(mainFolder);
                    Directory.CreateDirectory(mainFolder + "\\Important Stuff");
                    Directory.CreateDirectory(mainFolder + "\\Logs");
                    if (!File.Exists(mainFolder + @"\Important Stuff\localData.txt") || !File.Exists(mainFolder + @"\Important Stuff\data_" + userNew + ".txt") || !File.Exists(mainFolder + @"\Important Stuff\version.txt"))
                    {
                        File.Create(mainFolder + @"\Important Stuff\localData.txt");
                        File.Create(mainFolder + @"\Important Stuff\data_" + userNew.ToLower() + ".txt");
                        File.Create(mainFolder + @"\Important Stuff\version.txt");
                    }
                }
                catch(UnauthorizedAccessException)
                {
                    Console.WriteLine("The program could not access the file specified. Please make sure you system has access to " + tdgAppFolder);
                }
            }
            if(logFile == null)
            {
                Console.WriteLine(logFile);
                logFile = logService.createLog();
            }
            Console.WriteLine(logFile);
            try
            {
                using (FileStream fsData = File.OpenRead(mainFolder + @"\Important Stuff\version.txt"))
                {
                    string versionNum = File.ReadAllText(mainFolder + @"\Important Stuff\version.txt");
                    logService.editLog(Encoding.UTF8.GetBytes("--- TheDarkGamer Apps - Calculator3 - Version " + versionNum + " ---"), logFile);
                    fsData.Close();
                }
            }
            catch(IOException)
            {
                
            }
            if(!File.Exists(mainFolder + @"\Important Stuff\localData.txt") || !File.Exists(mainFolder + @"\Important Stuff\data_" + userNew + ".txt") || !File.Exists(mainFolder + @"\Important Stuff\version.txt"))
            {
                File.Create(mainFolder + @"\Important Stuff\localData.txt");
                File.Create(mainFolder + @"\Important Stuff\data_" + userNew.ToLower() + ".txt");
                File.Create(mainFolder + @"\Important Stuff\version.txt");
            }
            userInterface.isDev(mainFolder + @"\Important Stuff\localData.txt");
        }
        public static void processData()
        {

        }
        public static void distributeData()
        {

        }
    }
}
