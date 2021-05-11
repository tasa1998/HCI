using HCI_projekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Service
{
    public interface ILabelService
    {
        Boolean CreateLabel(Label label);
        List<Label> GetLabels();
        Boolean DeleteLabel(Label label);
        Boolean EditLabel(Label l);
    }
}
