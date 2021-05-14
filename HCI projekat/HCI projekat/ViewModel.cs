using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat
{
    public class ViewModel
    {
        public List<Model.Event> Data { get; set; }
        public ViewModel()
        {
            Data = App.EventController.GetEvents();
        }
    }
}
