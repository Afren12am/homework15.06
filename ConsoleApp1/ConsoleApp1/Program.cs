using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {

        public string FIO;
        public int age;
        public double weight;
        public string colorEyes;
        public Person()
        {
            FIO = "";
            colorEyes = "";
            age = 0;
            weight = 0;
        }
        public Person(string FIO, int age, double weight, string colorEyes)
        {
            this.FIO = FIO;
            this.colorEyes = colorEyes;
            this.age = age;
            this.weight = weight;

        }
        public void Print()
        {
            Console.WriteLine("Имя человека:" + FIO + "\nВозраст:" + age + "\nВес: " + weight
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