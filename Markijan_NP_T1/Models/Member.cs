using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_Gym.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Member(int id = 0, string firstName = " ", string lastName = " ", int age = 0)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string Print()
        {
            return $"{FirstName} {LastName}, Age: {Age}";
        }
    }
}
