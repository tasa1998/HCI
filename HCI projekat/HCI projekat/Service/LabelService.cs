using HCI_projekat.Model;
using HCI_projekat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Service
{
    public class LabelService : ILabelService
    {
        private LabelRepository _labelRepository;

        public LabelService(LabelRepository labelRepository)
        {
            _labelRepository = labelRepository;
        }
        public bool CreateLabel(Label label)
        {
            List<Label> labels = _labelRepository.GetAll(LabelRepository.path);
            if (labels == null)
                labels = new List<Label>();
            labels.Add(label);
            return _labelRepository.Save(labels, LabelRepository.path);
        }

        public List<Label> GetLabels()
        {
            return _labelRepository.GetAll(LabelRepository.path);
        }

        public Boolean DeleteLabel(Label label)
        {
            List<Label> labels = _labelRepository.GetAll(LabelRepository.path);

            if (labels == null)
                return false;

            foreach (Label label1 in labels)
            {
                if (label1.Mark.Equals(label.Mark))
                {
                    labels.Remove(label1);
                    break;
                }
            }
            return _labelRepository.Save(labels, LabelRepository.path);
        }

        public Boolean EditLabel(Label l)
        {
            if (DeleteLabel(l) == false)
                return false;
            return CreateLabel(l);
        }
    }
}
