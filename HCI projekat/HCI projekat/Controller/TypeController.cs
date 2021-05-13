using HCI_projekat.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Controller
{
    public class TypeController : ITypeController
    {
        private ITypeService _typeService;

        public TypeController (ITypeService typeService)
        {
            _typeService = typeService;
        }
        public bool CreateType(Model.Type t)
        {
            return _typeService.CreateType(t);
        }

        public bool DeleteType(Model.Type t)
        {
            return _typeService.DeleteType(t);
        }

        public bool EditType(Model.Type t)
        {
            return _typeService.EditType(t);
        }

        public List<Model.Type> GetTypes()
        {
            return _typeService.GetTypes();
        }
    }
}
