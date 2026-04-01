using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class SupportHandler
    {
        protected SupportHandler nextHandler;
        public void SetNext(SupportHandler handler)
        {
            nextHandler = handler;
        }
        public abstract void HandleRequest(string request);
    }
}
