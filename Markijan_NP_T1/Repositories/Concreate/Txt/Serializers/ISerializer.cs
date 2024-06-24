using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_Gym.Repositories.Concreate.Txt.Serializers
{
    public interface ISerializer<T>
    {
        T Deserialize(string line);
        string Serialize(T item);
    }
}
