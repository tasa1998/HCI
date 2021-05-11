using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll(String path);
        Boolean Save(List<T> objects, String path);
    }
}
