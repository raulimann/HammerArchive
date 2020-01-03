using System;

namespace HammerArchive
{
    /// <summary>
    /// Enum for the Logger
    /// </summary>
    public enum LogEnum
    {
        Information,
        Error
    }

    public class Util
    {
        /// <summary>
        /// Write to compile window
        /// </summary>
        /// <param name="info"></param>
        /// <param name="message"></param>
        public static void Log(LogEnum info, string message)
        {
            Console.WriteLine($"{info} - {message}");
        }
    }
}
