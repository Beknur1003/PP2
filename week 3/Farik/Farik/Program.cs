using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Farik
{
    class Program
    {
        static void print(DirectoryInfo d, int cursor)                //новый метод с новыми переменными directoryInfo d и cursor\\
        {
            Console.Clear();                                          //каждый раз консиль будет очищаться\\
            FileSystemInfo[] fsis = d.GetFileSystemInfos();          //создаем новый массив fsis и присваиваем туда из d, так как в FileSystemInfo уже есть directoryInfo и fileInfo\\
            for (int i = 0; i < fsis.Length; i++)                   //пробегаемся от 0 до длины массива fsis\\
            {
                if (fsis[i].GetType() == typeof(FileInfo))           //проверяем на тип файла, папка или файл\\
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;      //цвет букв\\
                }
                if (fsis[i].GetType() == typeof(DirectoryInfo))       //проверяем на тип файла, проверяем директорий или нет\\
                {
                    Console.ForegroundColor = ConsoleColor.Green;     //цвет букв\\
                }
                if (i == cursor)                                      //если наш курсор находится на индексе, то буквы серые. Если не так, то белые\\
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(fsis[i].Name);                      //выводим на консоль файл или папку с тем индексом\\
            }
        }

        public static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Asus\Desktop");      //создаем новый директорий d и считываем весь десктоп                   \\
            int cursor = 0;                                                    //по началу наш курсор находится сверху на 0 месте                        \\
            print(d, cursor);                                                 //используем метод сверху для подсветки выбранного файла или папки          \\
            int n = d.GetFileSystemInfos().Length;                           //создаем новую переменную равную длине папки или файла, это нужно для курсора\\

            while (true)                                                    //созадем бесконечный цикл\\
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();                 //считываем кнопки, чтобы делать действия\\
                if (keyInfo.Key == ConsoleKey.UpArrow)                     //если стрелка вверх то курсор--           \\
                {
                    cursor--;
                    if (cursor == -1)                                     //если курсор вышел за рамки, то он будет в самом низу консоли\\
                    {
                        cursor = n - 1;
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)                   //если стрелка вниз, то курсор++\\
                {
                    cursor++;
                    if (cursor == n)                                       //если в вышли за рамки снизу, то курсор будет сверху\\
                    {
                        cursor = 0; 
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)                        //если нажали интер, то идут условия на проверку типа файла\\
                {
                    if (d.GetFileSystemInfos()[cursor].GetType() == typeof(FileInfo))       //если это файл, то заходим в файл\\
                    {
                        Console.Clear();
                        StreamReader sr = new StreamReader(d.GetFileSystemInfos()[cursor].FullName);
                        Console.WriteLine(sr.ReadToEnd());
                        Console.ReadKey();
                    }
                    if (d.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))          //если это директория, то заходим в папку и тоже самое как изначально\\
                    {
                        Console.Clear();
                        d = new DirectoryInfo(d.GetFileSystemInfos()[cursor].FullName);
                        cursor = 0;                                                                 //курсор как в начале находится в самом вверху\\
                        n = d.GetFileSystemInfos().Length;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Escape)                       //если нажали на Escape, то проверяем есть ли родители у файла\\
                {
                    if (d.Parent != null)
                    {
                        d = d.Parent;
                        n = d.GetFileSystemInfos().Length;
                        cursor = 0;                                         //если есть, то курсор оказывается в са
                    }
                    else
                    {
                        break;                                              //если мы вышли дальше C, то программа выходит\\
                    }
                    if (keyInfo.Key == ConsoleKey.D)                        //удаляем файл\\
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
