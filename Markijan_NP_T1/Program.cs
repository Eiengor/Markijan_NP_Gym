using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_Gym.Models;
using Markijan_NP_Gym.Repositories;

namespace Markijan_NP_Gym
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.ShowMenu();
        }
    }
}
