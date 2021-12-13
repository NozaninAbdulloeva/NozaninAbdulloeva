using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestourantSHef_1999_1
{
    class ChikenOrder
    {
        int quantity;
        public ChikenOrder(int quantity)
        {
            this.quantity = quantity;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void CutUp()  { }
        public void Cook()
        {
            for (int i = 0; i < quantity; i++)
            {
                CutUp();    
            }
        }
    }
}
