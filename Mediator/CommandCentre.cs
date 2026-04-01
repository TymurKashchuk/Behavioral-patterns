using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private Dictionary<Aircraft, Runway> _activeLandings = new Dictionary<Aircraft, Runway>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            _runways.AddRange(runways);
            _aircrafts.AddRange(aircrafts);

            // Призначаємо всім літакам посередника
            foreach (var aircraft in aircrafts)
                aircraft.SetMediator(this);
        }

        public void LandAircraft(Aircraft aircraft)
        {
            var freeRunway = _runways.FirstOrDefault(r => !r.IsBusy);
            if (freeRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
                freeRunway.IsBusy = true;
                freeRunway.HighLightRed();
                _activeLandings[aircraft] = freeRunway;
                Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {freeRunway.Id}.");
            }
            else
            {
                Console.WriteLine($"No free runway for aircraft {aircraft.Name}. Please wait.");
            }
        }

        public void TakeOffAircraft(Aircraft aircraft)
        {
            if (_activeLandings.TryGetValue(aircraft, out Runway runway))
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
                runway.IsBusy = false;
                runway.HighLightGreen();
                _activeLandings.Remove(aircraft);
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off from runway {runway.Id}.");
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}
