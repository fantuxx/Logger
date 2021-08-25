using System;

namespace Migrator
{
    public class LogToConsole : ILooger
    {
        public void LogError(string info)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Log("Error at " +DateTime.Now +". ", info);
        }

        public void LogInfo(string info)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Log("Info at " + DateTime.Now + ". ", info);
        }

        public void LogWarning(string info)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Log("Warning at " + DateTime.Now + ". ", info);
        }


        public  static void Log(string logType, string messageToLog)
        {
            System.Console.WriteLine(logType + messageToLog);
        }
    }
}

