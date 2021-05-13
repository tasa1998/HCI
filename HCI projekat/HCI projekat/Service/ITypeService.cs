using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Service
{
    public interface ITypeService
    {
        Boolean CreateType(Model.Type t);
        List<Model.Type> GetTypes();
        Boolean DeleteType(Model.Type t);
        Boolean EditType(Model.Type t);
    }
}
