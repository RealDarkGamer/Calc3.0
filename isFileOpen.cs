using System;
using System.IO;

namespace Calculator3
{
    class isFileOpen
    {
        public bool FileIsLocked(string file)
        {
            bool blnReturn = false;
            FileStream fs;
            try
            {
                fs = File.Open(file, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                fs.Close();
            }
            catch (IOException)
            {
                blnReturn = true;
            }
            return blnReturn;
        }
    }
}
