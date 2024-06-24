using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_Gym.Repositories.Abstract
{
    public interface IRepos<T>
    {
        void Add(T entity);
        List<T> GetAll();
        int GetCount();
        void Refresh();
    }
}
