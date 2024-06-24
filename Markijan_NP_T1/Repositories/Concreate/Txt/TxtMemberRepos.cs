using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_Gym.Repositories.Abstract;
using Markijan_NP_Gym.Repositories.Concreate.Txt.Serializers;
using Markijan_NP_Gym.Models;


namespace Markijan_NP_Gym.Repositories.Concreate.Txt
{
    public class TxtMemberRepos : TxtRepository<Member>, IMemberRep
    {
        public TxtMemberRepos() : base(
            @"C:\OLeg\programs\csharps projects\Markijan_NP_T1\Markijan_NP_T1\Data\Member.txt", new MemberSerializer())
        { }
    }
}
