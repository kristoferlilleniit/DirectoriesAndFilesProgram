using System;
using System.IO;

namespace WriteFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilePath();
        }

        public static void WriteFilePath()
        {
            string filepath = @"C:\Users\opilane\Samples\files.txt";
            string directoryPath = @"C:\Users\opilane\Samples";
            string rootpath = @"C:\Users\opilane\Samples";
            string folderfilepath = @"C:\Users\opilane\Samples\directories.txt";

            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(filepath, files);

            string[] allDirectories = Directory.GetDirectories(rootpath);
            File.WriteAllLines(folderfilepath, allDirectories);

            string[] includeNestedDirectories = Directory.GetDirectories(rootpath, "*.*", SearchOption.AllDirectories);
            File.WriteAllLines(folderfilepath, includeNestedDirectories);

        }

    }
}
