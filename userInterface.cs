using System;
using System.IO;

namespace Calculator3
{
    class userInterface
    {
        public static void isDev(string localDataFile)
        {
            bool isUserDev = false;
            using (FileStream fsUi = File.OpenRead(localDataFile))
            {
                string localData = File.ReadAllText(localDataFile);
                if(localData.Contains("isDev: true"))
                {
                    Console.WriteLine("--- You are a developer. You can change this by going to " + localDataFile + " ---");
                    isUserDev = true;
                }
                fsUi.Close();
                userPrompt(localData);
            }
        }
        public static void userPrompt(string localData)
        {

        }
    }
}