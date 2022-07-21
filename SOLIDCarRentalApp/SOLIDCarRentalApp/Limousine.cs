using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCarRentalApp
{
    class Limousine : ICar
    {
        public string Features()
        {
            string message = ("Stereo Systems" + "\n" + "TV and Video Systems" + "\n" + "Intercom Facility " + "\n" + "Additional Multimedia Features " + "\n" + "Tinted Windows " + "\n" + "Climate Control Systems and Air - Conditioning. " + "\n" + "Upholstered Leather Seats. " + "\n" + "Refreshments.");
            return message;
        }

    }
}
