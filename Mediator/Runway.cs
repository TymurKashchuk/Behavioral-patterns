using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusy { get; set; }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
