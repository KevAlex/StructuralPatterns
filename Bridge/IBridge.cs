using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface IBridge
    {
        void ShowTotal(Dictionary<string, double> pProduct);
        void ProductsList(Dictionary<string, double> pProduct);
    }
}
