using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_Gym.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Membership(int id = 0, string name = " ", float price = 0)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public string Print()
        {
            return $"Name: {Name}\nPrice: {Price} $";            
        }
    }
}
