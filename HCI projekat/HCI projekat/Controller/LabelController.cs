using HCI_projekat.Model;
using HCI_projekat.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Controller
{
    public class LabelController : ILabelController
    {
        private ILabelService _labelService;

        public LabelController(ILabelService labelService)
        {
            _labelService = labelService;
        }
        public bool CreateLabel(Label label)
        {
            if (label == null)
            {
                return false;
            }
            return _labelService.CreateLabel(label);
        }

        public bool DeleteLabel(Label label)
        {
            return _labelService.DeleteLabel(label);
        }

        public bool EditLabel(Label label)
        {
            return _labelService.EditLabel(label);
        }

        public List<Label> GetLabels()
        {
            return _labelService.GetLabels();
        }
    }
}
