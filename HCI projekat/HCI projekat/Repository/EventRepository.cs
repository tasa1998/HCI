using HCI_projekat.Model;
using System;

namespace HCI_projekat.Repository
{
    public class EventRepository:Repository<Event>
    {
        public static String path = @"..\..\Resources\Data\Events.txt";
    }
}
