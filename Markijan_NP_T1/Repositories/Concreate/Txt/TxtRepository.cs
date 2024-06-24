using Markijan_NP_T1.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_T1.Repositories.Concreate.Txt.Serializers;

namespace Markijan_NP_T1.Repositories.Concreate.Txt
{
    public class TxtRepository<T> : IRepos<T>
    {
        private string filePath;
        private List<T> items;
        private ISerializer<T> serializer;

        public TxtRepository(string filePath, ISerializer<T> serializer)
        {
            this.filePath = filePath;
            this.serializer = serializer;
            items = new List<T>();
            ReadItemsFromFile();
        }
        public void Add(T item)
        {
            items.Add(item);
            WriteItemsToFile();
        }
        public List<T> GetAll()
        {
            return items;
        }
        public int GetCount()
        {
            return items.Count;
        }
        private void ReadItemsFromFile()
        {

            using (var streamReader = new StreamReader(filePath))
            {
                var lines = File.ReadLines(filePath).Where(line => !string.IsNullOrEmpty(line));
                items.AddRange(lines.Select(line => serializer.Deserialize(line)));
            }
        }
        private void WriteItemsToFile()
        {
            using (var streamWriter = new StreamWriter(filePath))
            {
                foreach (var item in items)
                    streamWriter.WriteLine(serializer.Serialize(item));
            }
        }
        public void Refresh()
        {
            items.Clear();
            ReadItemsFromFile();
        }
    }
}
