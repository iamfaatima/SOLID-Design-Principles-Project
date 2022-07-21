using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLIDCarRentalApp
{
    class Kia : ICar
    {
        public string Features()
        {
            string message =("181-horsepower 2.4-liter four-cylinder engine." + "\n" + "17 - inch alloy wheels. " + "\n" + "8 - inch touchscreen display. " + "\n" + "Six - speaker sound system.  " + "\n" + "USB port." + "\n" + "Apple CarPlay and Android Auto smartphone functionality. " + "\n" + "Selectable driving modes. " + "\n" + "60 / 40 - split folding and reclining back seat.");
            return message;
        }
    }
}
