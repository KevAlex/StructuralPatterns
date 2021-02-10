using Subystems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade
    {
        private SendSubsystem send = new SendSubsystem();
        private BuySystem buy = new BuySystem();
        private Store str = new Store();

        // The client (I) only sees the function Buy
        // Facade is in charge of the execution of all the different operations
        public void Buy()
        {
            if (buy.Buy())
            {
                if (str.GetOut())
                {
                    send.Snd();
                }
            }
        }

    }
}
