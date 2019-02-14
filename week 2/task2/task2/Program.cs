using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace example
{
    class Program
    {
        static bool prime(int n)                                                                     //создаем метод для нахождения прайм числа|
        {                                                                                           //                                         |
            if (n == 1 || n == 0) return false;                                                    // создаем условие, если n = 1 и n = 0      |
            for (int i = 2; i < n; i++)                                                           // создаем форик и пробегаемся от 0 до n     |
            {                                                                                    //                                            |
                if (n % i == 0) return false;                                                   // проверяем есть ли остаток при делении n на i|
            }                                                                                  //                                              |
            return true;                                                                      //                                               |
        }                                                                                    //                                                |
        public static void Main(String[] args)                                              //                                                 |
        {                                                                                  //                                                  |
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\text.txt");        //считываем данные из файла                          |
            string s = sr.ReadToEnd();                                                   //читаем до конца                                     |
            string[] arr = s.Split(' ');                                                //создаем массив и сплитуем все пробелы                |
            sr.Close();                                                                //закрываем стриридэр                                   |
            StreamWriter sw = new StreamWriter(@"C:\Users\Asus\Desktop\output.txt");  //записываем новую переменную sw в новый файл            |
            string res = "";                                                         //создаем переменную и присваиваем ему пустоту            |
            for (int i = 0; i < arr.Length; i++)                                    //создаем форик и пробегаемся от 0 до длины массива        |
            {                                                                      //                                                          |
                int num = int.Parse(arr[i]);                                      //                                                           |
                if (prime(num))                                                  //проверяю число на прайм                                     |
                {                                                               //                                                             |
                    res = res + num + " ";                                     //присваиваю res новые значения                                 |
                }                                                             //                                                               |
            }                                                                //                                                                |
            sw.Write(res);                                                  //выписываю значения res                                           |
            sw.Close();                                                    //закрыва sw                                                        |
        }
    }
}