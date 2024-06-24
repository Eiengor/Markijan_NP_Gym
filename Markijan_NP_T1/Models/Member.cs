using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_Gym.Models
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Member(string firstName = " ", string lastName = " ", int age = 0)
        {
            if(Age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
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
