using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_T1.Repositories.Concreate.Txt.Serializers
{
    public interface ISerializer<T>
    {
        T Deserialize(string line);
        string Serialize(T item);
    }
}
