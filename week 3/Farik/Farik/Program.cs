using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Farik
{
    class Program
    {
        static void print(DirectoryInfo d, int cursor)
        {
            Console.Clear();
            FileSystemInfo[] fsis = d.GetFileSystemInfos();
            for (int i = 0; i < fsis.Length; i++)
            {
                if (fsis[i].GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                if (fsis[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (i == cursor)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(fsis[i].Name);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Asus\Desktop");
            int cursor = 0;
            print(d, cursor);
            int n = d.GetFileSystemInfos().Length;

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor == -1)
                    {
                        cursor = n - 1;
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                    {
                        cursor = 0;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (d.GetFileSystemInfos()[cursor].GetType() == typeof(FileInfo))
                    {
                        Console.Clear();
                        StreamReader sr = new StreamReader(d.GetFileSystemInfos()[cursor].FullName);
                        Console.WriteLine(sr.ReadToEnd());
                        Console.ReadKey();
                    }
                    if (d.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        Console.Clear();
                        d = new DirectoryInfo(d.GetFileSystemInfos()[cursor].FullName);
                        cursor = 0;
                        n = d.GetFileSystemInfos().Length;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    if (d.Parent != null)
                    {
                        d = d.Parent;
                        n = d.GetFileSystemInfos().Length;
                        cursor = 0;
                    }
                    else
                    {
                        break;
                    }
                    if (keyInfo.Key == ConsoleKey.D)
                    {
                        if (d.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                        {
                            Directory.Delete(d.GetFileSystemInfos()[cursor].FullName, true);
                            cursor--;
                        }
                        if (d.GetFileSystemInfos()[cursor].GetType() == typeof(FileInfo))
                        {
                            Directory.Delete(d.GetFileSystemInfos()[cursor].FullName, true);
                            cursor--;
                        }
                    }
                }
                if (keyInfo.Key == ConsoleKey.R)
                {
                    if (d.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        Console.Clear();
                        string s = Console.ReadLine();
                        string file = d.GetFileSystemInfos()[cursor].Name;
                        string path = d.GetFileSystemInfos()[cursor].FullName;
                        int len = file.Length;
                        string newpath = "";
                        for (int i = 0; i < path.Length - len; i++)
                        {
                            newpath = newpath + s;
                            Directory.Move(d.GetFileSystemInfos()[cursor].FullName, newpath);
                        }
                    }
                    if (d.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        Console.Clear();
                        string s = Console.ReadLine();
                        string file = d.GetFileSystemInfos()[cursor].Name;
                        string path = d.GetFileSystemInfos()[cursor].FullName;

                        int len = file.Length;
                        string newpath = "";
                        for (int i = 0; i < path.Length - len; i++)
                        {
                            newpath = newpath + path[i];
                        }
                        newpath = newpath + s;
                        File.Move(d.GetFileSystemInfos()[cursor].FullName, newpath);
                    }
                }
                print(d, cursor);
            }
        }
    }
}
