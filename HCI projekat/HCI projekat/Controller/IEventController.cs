using HCI_projekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Controller
{
    public interface IEventController
    {
        Boolean CreateEvent(Event eventt);
        List<Event> GetEvents();
        Boolean DeleteEvent(Event eventt);
        Boolean EditEvent(Event eventt);
        Boolean SaveEvents(List<Event> events);
    }
}
