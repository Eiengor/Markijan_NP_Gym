using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_T1.Models;
using Markijan_NP_T1.Repositories;

namespace Markijan_NP_T1
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
