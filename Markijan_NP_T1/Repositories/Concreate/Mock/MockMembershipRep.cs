﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_Gym.Models;
using Markijan_NP_Gym.Repositories.Abstract;
using Markijan_NP_Gym.Repositories.Concreate.Memory;
using Markijan_NP_Gym.Repositories.Concreate.Mock;

namespace Markijan_NP_Gym.Repositories.Concreate.Mock
{
    public class MockMembershipRep : MemoryMembershipRep, IMembershipRep
    {
        public MockMembershipRep()
        {
            Add(new Membership
            {
                Name = "Silver",
                Price = 10
            });
            Add(new Membership
            {
                Name = "Gold",
                Price = 25
            });
            Add(new Membership
            {
                Name = "Platinum",
                Price = 40
            });
        }
    }
}
