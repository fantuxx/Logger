using System;
using System.IO;

namespace Migrator
{
    public class FileLogger : ILooger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string info)
        {
            Log("ERROR"+" Occured at "+ DateTime.Now, info);
        }

        public void LogInfo(string info)
        {
            Log("Info" +   DateTime.Now, info);
        }

        public void LogWarning(string info)
        {
            Log("Warning" + "|Ignorable|" + DateTime.Now, info);
        }


        private  void Log(string messageType, string message)
        {
            using (var st= new StreamWriter(_path, true))
            {
                st.WriteLine(messageType + " " + " " + message);
            }
        }
    }
}

