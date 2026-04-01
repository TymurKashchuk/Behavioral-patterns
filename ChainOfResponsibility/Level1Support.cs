using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Level1Support : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "1")
                Console.WriteLine("Рівень 1: Ми допомогли вам із базовою проблемою.");
            else if (nextHandler != null)
                nextHandler.HandleRequest(request);
            else
                Console.WriteLine("Невідома опція. Меню повторюється.");
        }
    }
}
