using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Level2Support : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "2")
                Console.WriteLine("Рівень 2: Ми вирішили вашу проблему середньої складності.");
            else if (nextHandler != null)
                nextHandler.HandleRequest(request);
            else
                Console.WriteLine("Невідома опція. Меню повторюється.");
        }
    }
}
