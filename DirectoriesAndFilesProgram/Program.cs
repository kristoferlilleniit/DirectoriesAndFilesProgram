using System;
using System.IO;

namespace DirectoriesAndFilesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\Samples";

            string[] allDirectories = Directory.GetDirectories(rootpath);
            ReadArray(allDirectories);

            string[] includeNestedDirectories = Directory.GetDirectories(rootpath, "*.*", SearchOption.AllDirectories);
            ReadArray(includeNestedDirectories);

            string[] files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);
        }

        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }
        }
    }
}
