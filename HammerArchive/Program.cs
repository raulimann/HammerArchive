using System;
using System.IO;
using System.IO.Compression;

namespace HammerArchive
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                try
                {
                    //Building variables
                    string pathArchive = args[0] + "_archive";
                    string identifyer = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}";
                    string pathZip = $@"{pathArchive}\{identifyer}.zip";

                    //Logging variables - Debug
                    Logger.Log(NotificationEnum.Information, $"Argument:           {args[0]}");
                    Logger.Log(NotificationEnum.Information, $"Path Archive:       {pathArchive}");
                    Logger.Log(NotificationEnum.Information, $"Path Zip:           {pathZip}");

                    //Creating archive folder
                    if (!Directory.Exists(pathArchive))
                    {
                        Logger.Log(NotificationEnum.Information, $"Creating Directory: {pathArchive}");
                        Directory.CreateDirectory(pathArchive);
                    }
                    else
                    {
                        Logger.Log(NotificationEnum.Information, $"Directory Found:    {pathArchive}");
                    }

                    //Creating Archive
                    Logger.Log(NotificationEnum.Information, $"Creating Archive:   {pathZip}");
                    ZipFile.CreateFromDirectory(args[0], pathZip);

                    //Force-exit - sometimes hammer keeps it running in the background
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    //Meh
                    Logger.Log(NotificationEnum.Error, ex.GetType().ToString());
                }
            }
            else
            {
                Logger.Log(NotificationEnum.Error, "Argument Exception");
            }
        }
    }
}
