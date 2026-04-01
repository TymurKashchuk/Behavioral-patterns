using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Level4Support : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "4")
                Console.WriteLine("Рівень 4: Адміністративна підтримка обробила ваше питання.");
            else
                Console.WriteLine("Невідома опція. Меню повторюється.");
        }
    }
}
