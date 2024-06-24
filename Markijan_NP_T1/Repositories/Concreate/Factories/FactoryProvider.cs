using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_T1.Repositories.Abstract;

namespace Markijan_NP_T1.Repositories.Concreate.Factories
{
    public class FactoryProvider
    {
        public static IReposFactory GetReposFactory()
        {
            return new TxtReposFactory();
        }
    }
}
