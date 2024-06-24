﻿using System;
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
    public class MockMemberRep : MemoryMemberRep, IMemberRep
    {
        public MockMemberRep()
        {
            Add(new Member
            {
                Id = 1,
                FirstName = "Oleh",
                LastName = "Haiduchok",
                Age = 18
            });
            Add(new Member
            {
                Id = 2,
                FirstName = "Arnold",
                LastName = "Shwarzneger",
                Age = 58
            });
            Add(new Member
            {
                Id = 3,
                FirstName = "Silvestr",
                LastName = "Stalone",
                Age = 51
            });
        }
    }
}