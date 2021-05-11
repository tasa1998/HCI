using HCI_projekat.Model;
using HCI_projekat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Service
{
    public class EventService : IEventService
    {
        private EventRepository _eventRepository;

        public EventService(EventRepository eventRepository) 
        {
            _eventRepository = eventRepository;
        }

        public Boolean SaveEvents(List<Event> events)
        {
            return _eventRepository.Save(events, EventRepository.path);
        }
        public bool CreateEvent(Event eventt)
        {
            List<Event> events = _eventRepository.GetAll(EventRepository.path);
            if (events == null)
                events = new List<Event>();
            events.Add(eventt);
            return _eventRepository.Save(events, EventRepository.path);
        }

        public List<Event> GetEvents()
        {
            return _eventRepository.GetAll(EventRepository.path);
        }

        public Boolean DeleteEvent(Event e)
        {
            List<Event> events = _eventRepository.GetAll(EventRepository.path);

            if(events == null)
                return false;

            foreach(Event eventt in events)
            {
                if (eventt.Mark.Equals(e.Mark))
                {
                    events.Remove(eventt);
                    break;
                }
            }
            return _eventRepository.Save(events, EventRepository.path);
        }

        public Boolean EditEvent(Event e)
        {
            if (DeleteEvent(e) == false)
                return false;
            return CreateEvent(e);
        }
    }
}
