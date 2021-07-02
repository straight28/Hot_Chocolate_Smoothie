using System;
using System.IO;

namespace FileCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 검색할 경로를 선택하세요.");
            string result1 = Console.ReadLine();

            Console.WriteLine(" 파일 확장자를 입력하세요. ");
            string result2 = Console.ReadLine();

            FileHandle test = new FileHandle();
            test.FileCheck(result1, result2);
        }
    }


    class FileHandle
    {
        public void FileCheck(string path, string file)
        {
            // string[] dir = Directory.GetDirectories(path, $"*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(path, $"*.{file}", SearchOption.AllDirectories);

            Console.WriteLine("=====================" + Environment.NewLine);

            foreach (var a in files)
            {
                FileInfo file1 = new FileInfo(a);

                //if(file1.Length > 100)
                //{
                Console.WriteLine(file1.Name);
                Console.WriteLine(file1.DirectoryName);
                Console.WriteLine(file1.Length);
                //}
            }
            Console.Read();
        }
    }



}
