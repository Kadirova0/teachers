using demo_1.Models;
using System;

using demo_1.Models;
using System;

namespace demo_1.Models
{
   public class Teacher: BaseEntity
    {
        private static int counter = 0;
        public Teacher (string name, string surname, decimal salary, DateTime birthDay) 
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Birthday = birthDay;

            Id = counter;
            counter++;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }
    }
}
