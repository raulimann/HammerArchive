using System;

namespace HammerArchive
{
    public class Logger
    {
        /// <summary>
        /// Write to compile window
        /// </summary>
        /// <param name="info"></param>
        /// <param name="message"></param>
        public static void Log(NotificationEnum info, string message)
        {
            Console.WriteLine($"{info} - {message}");
        }
    }
}
