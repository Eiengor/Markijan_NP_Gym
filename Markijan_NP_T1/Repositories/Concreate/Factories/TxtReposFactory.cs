using Markijan_NP_Gym.Repositories.Abstract;
using Markijan_NP_Gym.Repositories.Concreate.Txt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_Gym.Repositories.Concreate.Factories
{
    public class TxtReposFactory : IReposFactory
    {
        public IMemberRep GetMemberRep()
        {
            return new TxtMemberRepos();
        }
        public IMembershipRep GetMembershipRep()
        {
            return new TxtMembershipRepos();
        }

    }
}
