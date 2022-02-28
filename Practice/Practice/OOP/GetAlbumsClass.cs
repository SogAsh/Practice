using System;
using System.Collections.Generic;
using System.IO;

namespace Practice.OOP
{
    public class GetAlbumsClass
    {
        public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
        {
            var dirList = new List<DirectoryInfo>();
            var mp3 = "mp3";
            var wav = "wav";


            foreach (var file in files)
            {
                string[] delimiterChars = { "." };
                string[] words = file.FullName.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == mp3 || words[i] == wav)
                    {
                        dirList.Add(file.Directory);
                    }
                }
            }
            
            for (int i = dirList.Count - 1; i >= 0; i--)
            {
                if (dirList[i].FullName == dirList[i-1].FullName)
                    dirList.RemoveAt(i);
                
                if (dirList.Count == 1)
                    break;
            }

            foreach (var file in dirList)
                Console.WriteLine(file);
                    
            return dirList;
        }
    }
}