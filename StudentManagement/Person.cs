using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Person
    {
        public static int nextId = 0;
        private int id;
        private string name;
        private DateTime birthDate;
        private string address;
        private double height;
        private double weight;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Address { get => address;set => address = value; }
        public double Height { get => height;set => height = value; }
        public double Weight { get => weight; set => weight = value; }

       protected Person(string name, DateTime birthDate, string address, double height, double weight)
        {
            nextId = nextId + 1;
            Name = name;
            BirthDate = birthDate;
            Address = address;
            Height = height;
            Weight = weight;
        }

        protected Person()
        {
        }

        public override string? ToString()
        {
            return $"Id: {Id} ;" +
                $"  Name: {Name};" +
                $"    BirthDate:" +
                $"  {BirthDate};" +
                $"    Address: {Address};" +
                $"   Height: {Height};" +
                $"   Weight: {Weight}";
        }
    }
}
