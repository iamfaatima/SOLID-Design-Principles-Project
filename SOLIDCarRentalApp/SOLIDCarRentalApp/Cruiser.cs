using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCarRentalApp
{
    class Cruiser : IBike
    {
        public string Features()
        {
            string message = ("Cruiser bikes are a great way to keep active while you're on vacation in a very low-key way. Bicycles are naturally a low-impact workout. Not only can you get a full-body workout but you also strengthen your muscles, increase flexibility, fight fatigue, and reduce mental blocks.");
            return message;
        }

    }
}
