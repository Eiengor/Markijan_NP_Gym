using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_Gym.Models
{
    public class Membership
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Membership(string name = " ", float price = 0)
        {
            if (Price < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
            Name = name;
            Price = price;
        }
        public string Print()
        {
            return $"Name: {Name}\nPrice: {Price} $";            
        }
    }
}
