using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }

        public Person(int id, string name, DateTime birthDate, string address, double height, double weight)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Address = address;
            Height = height;
            Weight = weight;
        }

        public Person()
        {
        }

        public override string? ToString()
        {
            return $"Id: {Id} ;  Name: {Name};    BirthDate:  {BirthDate};    Address: {Address};   Height: {Height};   Weight: {Weight}";
        }
    }
}
