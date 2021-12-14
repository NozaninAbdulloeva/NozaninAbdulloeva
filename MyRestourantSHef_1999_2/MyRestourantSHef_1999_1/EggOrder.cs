using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRestourantSHef_1999_1
{
    class EggOrder:Order
    {        
        Random rnd = new Random();
        private int? quality=null;
        public EggOrder(int quantity):base(quantity)
        {          
        }        
        public int? GetQuality()
        {
            quality = rnd.Next(25, 100);                    
            return quality;
        }
        private void Crack()
        {
        }
        private void DiscardShell() { }
        public override void Cook()
        {
            for (int i = 0; i < GetQuantity(); i++)
            {
                Crack();
                DiscardShell();                      
            }
        }
    }
}
