﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_Gym.Services.Abstract;
using Markijan_NP_Gym.Models;

namespace Markijan_NP_Gym.Services.Concreate
{
    public class MemberService : IMemberService
    {
        public Member GetOldestMember(List<Member> members)
        {
            var maxAge = members.Max(x => x.Age);
            return members.Where(x => x.Age == maxAge).FirstOrDefault();
        }
    }
}
