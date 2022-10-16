using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public delegate void EventManager();
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink=null;
        static int i;
        public Events(string eventName)
        {
            _eventName=eventName;
        }
        public static void EventStarter()
        {
            i=0;
            System.Console.WriteLine("User Registration");
            HandleEvent();
        }
        public static void HandleEvent()
        {
            i=0;
            System.Console.WriteLine("User Registration");
            System.Console.WriteLine("Starting the following events ");
            eventlink();
        }
        public void ShowEvent()
        {
            ++i;
            System.Console.WriteLine("Event NO: "+i+ "is" +_eventName+"Started");
        }
    }
}