using Markijan_NP_T1.Repositories.Abstract;
using Markijan_NP_T1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_T1.Repositories.Concreate.Memory
{
    public class MemoryRepos<T> : IRepos<T>
    {
        private List<T> items;
        public MemoryRepos()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public List<T> GetAll()
        {
            return items;
        }
        public int GetCount()
        {
            return items.Count;
        }
        public void Refresh()
        {
            return;
        }
    }
}
