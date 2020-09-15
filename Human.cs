using System;
using System.Security.Cryptography.X509Certificates;

namespace Person_Kiemtra
{
    public class Human : Person
    {
        public string gender;
        public void getInfo()
        {
            Console.WriteLine("Ten: {0}", name);
            Console.WriteLine("Tuoi: {0}", age);
            Console.WriteLine("Gioi tinh: {0}", gender);
        }
        public Human(string name, string age, string gender) :base(name, age)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

    }
}
