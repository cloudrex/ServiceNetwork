using System;

namespace ServiceNetwork.Hub
{
    public static class Log
    {
        // TODO
        public static void Write(string message, LogType type = LogType.Verbose)
        {
            Console.WriteLine(message);
        }

        public static void Verbose(string message)
        {
            Log.Write(message);
        }
    }
}
