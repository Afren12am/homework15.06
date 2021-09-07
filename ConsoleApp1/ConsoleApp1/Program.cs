using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {

        public string FIO;
        public int age;
        public double ves;
        public string colorEyes;
        public Person()
        {
            FIO = "";
            colorEyes = "";
            age = 0;
            ves = 0;
        }
        public Person(string FIO, int age, double ves, string colorEyes)
        {
            this.FIO = FIO;
            this.colorEyes = colorEyes;
            this.age = age;
            this.ves = ves;

        }
        public void Print()
        {
            Console.WriteLine("Имя человека:" + FIO + "\nВозраст:" + age + "\nВес: " + ves
                              + "\nЦвет глаз: " + colorEyes);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person artem = new Person("Lukmanov Artem Ildarovich", 18, 67, "Green");

            artem.Print();

        }
    }
}