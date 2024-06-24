using System;
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
    public class MockMemberRep : MemoryMemberRep, IMemberRep
    {
        public MockMemberRep()
        {
            Add(new Member
            {
                FirstName = "Oleh",
                LastName = "Haiduchok",
                Age = 18
            });
            Add(new Member
            {
                FirstName = "Arnold",
                LastName = "Shwarzneger",
                Age = 58
            });
            Add(new Member
            {
                FirstName = "Silvestr",
                LastName = "Stalone",
                Age = 51
            });
        }
    }
}
