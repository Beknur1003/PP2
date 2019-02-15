using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    //FIELD
    //CONSTRUCTOR
    //METHOD

    class Student
    {
        private string name;                                     //private - модификатор доступа, обратная паблика. Прайвет доступен только из кода в том же классе
        private string id;
        private int yearofstudy;

        public Student(string name, string id)
        {
            this.name = name;                                       //ключевое слово this ссылается на текущий экземпляр класса, так как имеются одинаковые мена в коде\\
            this.id = id;
        }

        public string getName()                                       
        {
            return this.name;
        }
        public string getId()
        {
            return this.id;
        }
        public int Increment()                 //инкремент это как cnt++
        {
            return ++yearofstudy;
        }

    }
}