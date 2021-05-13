using HCI_projekat.Controller;
using HCI_projekat.Repository;
using HCI_projekat.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HCI_projekat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            EventRepository eventRepository = new EventRepository();
            LabelRepository labelRepository = new LabelRepository();
            TypeRepository typeRepository = new TypeRepository();
            var eventService = new EventService(eventRepository);
            var labelService = new LabelService(labelRepository);
            var typeService = new TypeService(typeRepository);

            EventController = new EventController(eventService);
            LabelController = new LabelController(labelService);
            TypeController = new TypeController(typeService);
        }
        public static IEventController EventController { get; private set; }
        public static ILabelController LabelController { get; private set; }
        public static ITypeController TypeController { get; private set; }
    }
}
