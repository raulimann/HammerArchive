using System;
using System.IO;
using System.IO.Compression;

namespace HammerArchive
{
    class HammerArchive
    {
        public static void Startup(string[] args)
        {
            try
            {
                if (args.Length == 2)
                {
                    //Building variables
                    string pathFolder = args[0];
                    string mapName = args[1];
                    string identifyer = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}";
                    string pathArchiveFolder = $"{pathFolder}_archive";
                    string pathMapArchiveFolder = $@"{pathArchiveFolder}\{mapName}";
                    string pathZip = $@"{pathMapArchiveFolder}\{identifyer}.zip";
                    string pathTemp = $@"{pathFolder}\temp";

                    //Logging variables - Debug
                    Util.Log(LogEnum.Information, $"Map Name:                {mapName}");
                    Util.Log(LogEnum.Information, $"Root Path:               {pathFolder}");
                    Util.Log(LogEnum.Information, $"Unique Identifyer:       {identifyer}");
                    Util.Log(LogEnum.Information, $"Archive Folder Path:     {pathArchiveFolder}");
                    Util.Log(LogEnum.Information, $"Archive Map Folder Path: {pathMapArchiveFolder}");
                    Util.Log(LogEnum.Information, $"Zip File Path:           {pathZip}");
                    Util.Log(LogEnum.Information, $"Temp Folder Path:        {pathTemp}");

                    //Build Folder Structure
                    CreateFolder(pathArchiveFolder);
                    CreateFolder(pathMapArchiveFolder);
                    CreateFolder(pathTemp);

                    //Searching Files
                    Util.Log(LogEnum.Information, $"Searching for all files containing: \"{mapName}\" in dir \"{pathFolder}\"");
                    foreach (var item in Directory.GetFiles(pathFolder, "*", SearchOption.AllDirectories))
                    {
                        if (item.Contains(mapName))
                        {
                            Util.Log(LogEnum.Information, $"Found file: {Path.GetFileName(item)}");
                            File.Copy(item, pathTemp + @"\" + Path.GetFileName(item));
                        }
                    }

                    //Creating Archive
                    Util.Log(LogEnum.Information, $"Creating Archive: {pathZip}");
                    ZipFile.CreateFromDirectory(pathTemp, pathZip);

                    //Cleaning up
                    Directory.Delete(pathTemp, true);
                    Environment.Exit(0);
                }
                else
                {
                    throw new ArgumentException("Please add the Arguments '$path $file'");
                }
            }
            catch (Exception ex)
            {
                //Meh
                Util.Log(LogEnum.Error, ex.GetType().ToString());
                Util.Log(LogEnum.Error, ex.Message);
            }
        }

        private static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Util.Log(LogEnum.Information, $"Creating Directory: {path}");
                Directory.CreateDirectory(path);
            }
        }
    }
}
