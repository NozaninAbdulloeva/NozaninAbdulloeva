using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestourantSHef_1999_1
{
    class Cook
    {    Order order;
        public void SubmitRequest(int quantity, Menu menu)
        {
            if (menu == Menu.Chicken)
            {
                order = new ChikenOrder(quantity);
            }
            else
            {
                order = new EggOrder(quantity);
            }
        }
        public void PrepareFood()
        {
            if (order is ChikenOrder)
            {
                for (int i = 0; i < order.GetQuantity(); i++)
                {
                    order.Cook();
                }
            }
            else if (order is EggOrder)
            {
                for (int i = 0; i < order.GetQuantity(); i++)
                {
                    order.Cook();
                }
            }
        }
    }
}
