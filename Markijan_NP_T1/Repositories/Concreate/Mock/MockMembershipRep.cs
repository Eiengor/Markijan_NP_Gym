using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_T1.Models;
using Markijan_NP_T1.Repositories.Abstract;
using Markijan_NP_T1.Repositories.Concreate.Memory;
using Markijan_NP_T1.Repositories.Concreate.Mock;

namespace Markijan_NP_T1.Repositories.Concreate.Mock
{
    public class MockMembershipRep : MemoryMembershipRep, IMembershipRep
    {
        public MockMembershipRep()
        {
            Add(new Membership
            {
                Id = 1,
                Name = "Silver",
                Price = 10
            });
            Add(new Membership
            {
                Id = 2,
                Name = "Gold",
                Price = 25
            });
            Add(new Membership
            {
                Id = 2,
                Name = "Platinum",
                Price = 40
            });
        }
    }
}
