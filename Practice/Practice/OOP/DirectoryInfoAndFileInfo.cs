using System;
using System.IO;

namespace Practice.OOP
{
    public class DirectoryInfoAndFileInfo
    {
        public static void WriteFile(FileInfo file, string content)
        {
            File.WriteAllText(file.FullName, content);
            Console.WriteLine(content);
        }


        //DirectoryInfo, FileInfo https://ulearn.me/course/basicprogramming/DirectoryInfo_FileInfo_57b32e15-beed-4e75-9aee-dabc6af80bd7
        public static void NewMain3()
        {
            // foreach (var fileName in Directory.GetFiles(".")) //D:\StudyPlace\Practice\Practice\Practice\bin\Debug
            //     Console.WriteLine(fileName);

            var dir = new DirectoryInfo(".");
            //foreach (var file in dir.GetFiles())
            FileInfo[] fi = dir.GetFiles();
            
            foreach (FileInfo fiTemp in fi)
                Console.WriteLine(fiTemp);
            
            // Console.WriteLine(file.FullName);
        }
    }
}