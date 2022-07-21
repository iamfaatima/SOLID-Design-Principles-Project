using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCarRentalApp
{
    class Sports : IBike
    {
        public string Features()
        {
            string message = ("Characteristics of a Sports Bike:" + "\n" + "They feature a high-revving & smooth engine, making the sports bikes sprint faster than other types of bikes.According to their usage, the sports bikes have four main categories: Lightweight, Middleweight and Super Sports, and Hyper sports bikes.");
            return message;
        }

    }
}
