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
        private string name;
        private string id;
        private int yearofstudy;

        public Student(string name, string id)
        {
            this.name = name;
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
        public int Increment()
        {
            return ++yearofstudy;
        }

    }
}