using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_Gym.Models;

namespace Markijan_NP_Gym.Repositories.Concreate.Txt.Serializers
{
    public class MemberSerializer : ISerializer<Member>
    {
        private char sep = ';';
        public Member Deserialize(string line)
        {
            var parts = line.Split(sep);
            return new Member
            {
                FirstName = parts[0],
                LastName = parts[1],
                Age = Convert.ToInt32(parts[2])
            };
        }
        public string Serialize(Member member)
        {
            return $"{member.FirstName}{sep}{member.LastName}{sep}{member.Age}";
        }
    }
}
