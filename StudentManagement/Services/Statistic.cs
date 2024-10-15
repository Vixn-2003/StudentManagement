using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Model;
namespace StudentManagement.Services
{
    internal class Statistic
    {
        private Manager manager;
        

        // Constructor that accepts a Manager object
        public Statistic(Manager manager)
        {
            this.manager = manager;
        }
        public void AcademicPerformace()
        {
            Console.Clear();
            var resultStatistic = manager.students
                .GroupBy(student => student.CheckAcademicPerformance(student.GPA))
                .OrderByDescending(group => group.Count())
                .Select(group => new
                {
                    Percent = $"{group.Key} : {(double)group.Count() * 100/ manager.students.Count() : F2}%" +
                              $"Quantity: {group.Count()} "
                });
            Console.WriteLine("Statistic by academic performance\n");
            resultStatistic.ToList().ForEach(x => Console.WriteLine(x.Percent));
        }
        public void GPA()
        {
            Console.Clear ();
            Console.WriteLine("Statistic by GPA\n");
            var resultStatistic = manager.students
                .GroupBy(student => student.GPA)
                .Select(group => new 
                { 
                    Percent =   $"Point: {group.Key : F2} " +
                                $"{(double)group.Count() *100 / manager.students.Count() : F2}%" +
                                $" Quantity: {group.Count()}"
                
                });
            resultStatistic.ToList().ForEach(a => Console.WriteLine(a.Percent));

        }
    }
}
