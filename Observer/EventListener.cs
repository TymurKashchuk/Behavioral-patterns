using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class EventListener : IEventListener
    {
        private string _name;
        public EventListener(string name)
        {
            _name = name;
        }

        public void Update(string eventType, LightElementNode element) {
            Console.WriteLine($"{_name} received event '{eventType}' from <{element.TagName}>");
        }
    }
}
