using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___05._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileArray = Directory.GetFiles(".", "*.*");

            var dict = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo dirInfo = new DirectoryInfo(".");

            FileInfo[] allFiles = dirInfo.GetFiles();

            foreach (FileInfo file in allFiles)
            {
                double size = file.Length / 1024d;
                string extension = file.Extension;
                string fileName = file.Name;

                if (!dict.ContainsKey(extension))
                {
                    dict[extension] = new Dictionary<string, double>();
                }

                if (!dict[extension].ContainsKey(fileName))
                {
                    dict[extension][fileName] = size;
                }

            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

            foreach (var file in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                File.AppendAllText(path,file.Key + Environment.NewLine);
                foreach (var item in file.Value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path, $"--{item.Key} - {Math.Round(item.Value,3)}kb" + Environment.NewLine);
                }
            }
        }
    }
}
