using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.IO.Compression;

namespace Exercise___06._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string picFolderPath = ".";
            string targetPath = "../../../result.zip";

            ZipFile.CreateFromDirectory(picFolderPath, targetPath);

            ZipFile.ExtractToDirectory(targetPath, "../../");
        }
    }
}
