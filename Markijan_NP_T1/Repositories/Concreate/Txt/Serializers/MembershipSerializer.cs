using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_Gym.Models;
namespace Markijan_NP_Gym.Repositories.Concreate.Txt.Serializers
{
    public class MembershipSerializer : ISerializer<Membership>
    {
        private char sep = ';';
        public Membership Deserialize(string line)
        {
            var parts = line.Split(sep);
            return new Membership
            {
                Name = parts[0],
                Price = Convert.ToInt32(parts[1])
            };
        }
        public string Serialize(Membership membership)
        {
            return $"{membership.Name}{sep}{membership.Price}";
        }
    }
}
