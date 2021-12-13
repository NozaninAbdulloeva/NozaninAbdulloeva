using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRestourantSHef_1999_1
{
    class EggOrder
    {
        static int countOfOrdered; 
        int quantity;
        Random rnd = new Random();
        int? quality=null;
        public EggOrder(int quantity)
        {
            countOfOrdered++;
            this.quantity = quantity;
        }

        public int GetQuantity()
        {
            return quantity;
        }
        public int? GetQuality()
        {
            if (countOfOrdered % 2==1)
            {
                quality = rnd.Next(1, 100);
            }            
            return quality;
        }

        public void Crack()
        {                   
             if (quality<25)            
             throw new Exception("Rotten egg");  
        }
        public void DiscardShell() { }
        public void Cook()
        {
            for (int i = 0; i < quantity; i++)
            {
                try
                {
                 Crack();
                }
                finally
                {
                 DiscardShell();
                }                          
            }
        }
    }
}
