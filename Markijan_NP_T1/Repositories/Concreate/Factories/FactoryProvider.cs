using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_Gym.Repositories.Abstract;

namespace Markijan_NP_Gym.Repositories.Concreate.Factories
{
    public class FactoryProvider
    {
        public static IReposFactory GetReposFactory()
        {
            return new TxtReposFactory();
        }
    }
}
