
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Services;

namespace StudentManagement.Model
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
        public string Address { get => address; set => address = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }

        protected Person(string name, DateTime birthDate, string address, double height, double weight)
        {
            this.id = ++nextId;
            this.name = name;
            this.birthDate = birthDate;
            this.address = address;
            this.height= height;
            this.weight = weight;
        }

        protected Person()
        {
            this.id = ++nextId;
        }
        public virtual void Input()
        {
            InputData inputData = new InputData();  
           
            Name = inputData.InputFullName();
            BirthDate = inputData.InputDateOfBirth();
            Address = inputData.InputAddress();
            Height = inputData.InputHeight();
            Weight = inputData.InputWeight();
        }

        public override string? ToString()
        {
            return $"Id: {this.id} ;" +
                $"  Name: {this.name};" +
                $"    BirthDate:" +
                $"  {this.birthDate};" +
                $"    Address: {this.address};" +
                $"   Height: {this.height};" +
                $"   Weight: {this.weight}";
        }
    }
}
