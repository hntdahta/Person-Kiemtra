using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Person_Kiemtra
{
    public class Person
    {
        public string name;
        public string age;
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(string age)
        {
            this.age = age;
        }
        public string getName(string name)
        {
            return name;
        }
        public string getAge(string age)
        {
            return age;
        }
        public string getInfo()
        {
            return name + age;
        }
        public Person(string name, string age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
