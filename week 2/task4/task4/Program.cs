using System;                                                                                 //\/\\\
using System.Collections.Generic;                                                            //\/\/\\\
using System.Linq;                                                                          //\/\/\/\\\
using System.Text;                                                                         //\/\/\/\/\\\
using System.Threading.Tasks;                                                             //\/\/\/\/\/\\\
using System.IO;                                                                         //\/\/\/\/\/\/\\\
                                                                                        //\/\/\/\/\/\/\/\\\
                                                                                       //\/\/\/\/\/\/\/\/\\\
namespace example                                                                     //\/\/\/\/\/\/\/\/\/\\\
{                                                                                    //\/\/\/\/\/\/\/\/\/\/\\\
    class Program                                                                   //\/\/\/\/\/\/\/\/\/\/\/\\\
    {                                                                              //\/\/\/\/\/\/\/\/\/\/\/\/\\\
        public static void Main(String[] args)                                    //\/\/\/\/\/\/\/\/\/\/\/\/\/\\\
        {                                                                        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\\
            string fileName = "test.txt";                                       //VS сам создаст файл            \\
            string path = @"C:\Users\Asus\Desktop\" + fileName;                //создаем test.txt в десктопе      \\
            string path1 = @"C:\Users\Asus\Desktop\davai\" + fileName;        //создаем test.txt в папке davai     \\
            StreamWriter sw = new StreamWriter(path);                        //записываем новую переменную sw в path\\
            sw.Write(12345);                                                //записываем в sw "12345"                \\
            sw.Close();                                                    //                                         \\
            File.Copy(path, path1);                                       //копируем path в path1                      \\
            File.Delete(path);                                           //удаляем path                                 \\

        }
    }
}