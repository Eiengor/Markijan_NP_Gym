using Markijan_NP_Gym.Repositories.Abstract;
using Markijan_NP_Gym.Repositories.Concreate.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_Gym.Repositories.Concreate.Factories
{
    public class MockRepFactory : IReposFactory
    {
        public IMemberRep GetMemberRep()
        {
            return new MockMemberRep();
        }
        public IMembershipRep GetMembershipRep()
        {
            return new MockMembershipRep();
        }
    }
}
