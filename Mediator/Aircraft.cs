using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }

        private CommandCentre? _mediator;

        public Aircraft(string name)
        {
            Name = name;
        }

        public void SetMediator(CommandCentre mediator)
        {
            _mediator = mediator;
        }

        public void RequestLanding()
        {
            if (_mediator != null)
                _mediator.LandAircraft(this);
        }

        public void RequestTakeOff()
        {
            if (_mediator != null)
                _mediator.TakeOffAircraft(this);
        }
    }
}
