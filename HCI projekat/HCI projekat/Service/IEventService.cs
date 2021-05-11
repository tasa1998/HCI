using HCI_projekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Service
{
    public interface IEventService
    {
        Boolean CreateEvent(Event eventt);
        List<Event> GetEvents();
        Boolean DeleteEvent(Event e);
        Boolean EditEvent(Event e);
        Boolean SaveEvents(List<Event> events);
    }
}
