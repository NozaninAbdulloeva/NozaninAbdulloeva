using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestourantSHef_1999_1
{
    class ChikenOrder:Order
    {
        public ChikenOrder(int quantity):base(quantity)
        {
          
        }       
        private void CutUp()  { }
        public override void Cook()
        {
            for (int i = 0; i <GetQuantity() ; i++)
            {
                CutUp();
            }
        }

    }
}
