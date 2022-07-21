using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCarRentalApp
{
    class Touring : IBike
    {
        public string Features()
        {

            string message = ("Frame Geometry for Touring Bikes" + "\n" + "Number of spokes: With all that weight you’re hauling on your touring bike, it’s good to think about the strength of the wheels. More spokes typically mean stronger wheels, so a good general recommendation is to choose wheels that have at least 32 spokes. Wheels with 36 spokes are often a better choice if you’re going to be carrying lots of weight and/or riding on rough roads.");
            return message;
        }

    }
}
