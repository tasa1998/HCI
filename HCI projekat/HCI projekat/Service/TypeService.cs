using HCI_projekat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Service
{
    public class TypeService : ITypeService
    {
        private TypeRepository _typeRepository;

        public TypeService (TypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
        public bool CreateType(Model.Type t)
        {
            List <Model.Type> types = _typeRepository.GetAll(TypeRepository.path);
            if (types == null)
                types = new List<Model.Type>();
            types.Add(t);
            return _typeRepository.Save(types, TypeRepository.path);
        }

        public bool DeleteType(Model.Type t)
        {
            List<Model.Type> labels = _typeRepository.GetAll(TypeRepository.path);

            if (labels == null)
                return false;

            foreach (Model.Type label1 in labels)
            {
                if (label1.Mark.Equals(t.Mark))
                {
                    labels.Remove(label1);
                    break;
                }
            }
            return _typeRepository.Save(labels, TypeRepository.path);
        }

        public bool EditType(Model.Type t)
        {
            if (DeleteType(t) == false)
                return false;
            return CreateType(t);
        }

        public List<Model.Type> GetTypes()
        {
            return _typeRepository.GetAll(TypeRepository.path);
        }
    }
}
