using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCarRentalApp
{
    class Factory
    {
        public static ICar createObjectOfCar(int num)
        {
            if(num == 1)
            {
                return new Kia();
            }
            else if (num == 2)
            {
                return new Mercedes();
            }
            else if (num == 3)
            {
                return new Limousine();
            }
            else
            {
                return null;
            }
        }

        public static IBike createObjectOfBike(int num)
        {
            if (num == 1)
            {
                return new Sports();
            }
            else if (num == 2)
            {
                return new Touring();
            }
            else if (num == 3)
            {
                return new Cruiser();
            }
            else
            {
                return null;
            }
        }
    }
}
