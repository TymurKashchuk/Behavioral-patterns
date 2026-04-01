using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Level3Support : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "3")
                Console.WriteLine("Рівень 3: Експертна підтримка вирішила вашу складну проблему.");
            else if (nextHandler != null)
                nextHandler.HandleRequest(request);
            else
                Console.WriteLine("Невідома опція. Меню повторюється.");
        }
    }
}
