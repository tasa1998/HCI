using HCI_projekat.Model;
using HCI_projekat.Service;
using System;
using System.Collections.Generic;

namespace HCI_projekat.Controller
{
    public class EventController : IEventController
    {
        private IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;

        }

        public EventController()
        {

        }
        public Boolean SaveEvents(List<Event> events)
        {
            return _eventService.SaveEvents(events);
        }

        public Boolean CreateEvent(Event eventt)
        {
            if(eventt == null)
            {
                return false;
            }
            return _eventService.CreateEvent(eventt);
        }

        public List<Event> GetEvents()
        {
            return _eventService.GetEvents();
        }

        public Boolean DeleteEvent(Event eventt)
        {
            return _eventService.DeleteEvent(eventt);
        }

        public Boolean EditEvent(Event eventt)
        {
            return _eventService.EditEvent(eventt);
        }
    }
}
