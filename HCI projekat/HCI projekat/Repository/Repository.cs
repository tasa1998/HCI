using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Repository
{
    public class Repository<T>: IRepository<T>
    {
        public List<T> GetAll(string path)
        {
            String text = "";
            if (File.Exists(path))
                text = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<T>>(text);
        }

        public bool Save(List<T> objects, string path)
        {
            string json = JsonConvert.SerializeObject(objects, Formatting.Indented);
            File.WriteAllText(path, json);
            return true;
        }
    }
}
