using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCarRentalApp
{
    class Mercedes : ICar
    {
        public string Features()
        {
            string message = ("Extensive range of vehicles. From the dynamic and highly efficient new A-Class to the luxurious and spacious E-Class or S-Class, we offer a wide range of vehicles to suit you and your requirements. " + "\n" + " Outstanding cost-efficiency. " + "\n" + "Class leading safety. " + "\n" + "Strong residual values." + "\n" + "Expertise and flexibility.");
            return message;
        }
    }
}
