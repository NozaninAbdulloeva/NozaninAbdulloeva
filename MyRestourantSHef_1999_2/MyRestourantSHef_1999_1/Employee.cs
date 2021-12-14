using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestourantSHef_1999_1
{
    class Employee
    {   int totalOrder;        
        object copyMenu;
        object order = null;
        object copyOrder;
        bool isRequest;
        bool isCopy;
        public Employee()
        {
        }
        public object NewRequest(int quantity, string menuItem)
        {
            totalOrder++;

            if (totalOrder % 3 == 0)
            {
                menuItem = menuItem == "Chicken" ? "Egg" : "Chicken";
            }

            if (menuItem == "Chicken")
            {
                order = new ChikenOrder(quantity);
            }
            else
            {
                order = new EggOrder(quantity);
            }
            copyMenu = order;
            isRequest = true;
            isCopy = true;
            return order;
        }
        public object CopyRequest()
        {
            int quantityFood;
            if (isCopy)
            {               
                if (copyMenu is EggOrder)
                {
                    var egg = (EggOrder)copyMenu;
                  quantityFood= egg.GetQuantity();                                 
                   copyOrder = new EggOrder(quantityFood); 
                }
                else
                {
                    var chicken = (ChikenOrder)copyMenu;
                    quantityFood= chicken.GetQuantity();                    
                    copyOrder = new ChikenOrder(quantityFood);
                }
                isCopy = false;
                isRequest = true;                       
            }
            else
            {
                throw new Exception("No request, can nott COPY!!!");
            }
            return copyOrder;  
        }
        public string Inspect(object menu)
        {
            string inspect;
            if (menu is EggOrder)
            {
                var egg = menu as EggOrder;
                inspect= $"Egg quality : {egg.GetQuality().ToString()}";
            }
            else
            {
                inspect = "Chicken havn't quality";
            }
            return inspect;
        }
        public string PrepareFood(object request)
        {
            int orderQuantity = 0;
            string nameOrder = "";
            string SOS="";
            if (isRequest)
            {               
                if (request is ChikenOrder)
                {
                    ChikenOrder chicken = (ChikenOrder)request;
                    chicken.Cook();
                    orderQuantity = chicken.GetQuantity();
                    nameOrder = "chicken";
                }
                else if (request is EggOrder)
                {
                    EggOrder egg = (EggOrder)request;
                    egg.Cook();
                    orderQuantity = egg.GetQuantity();
                    nameOrder = "egg";
                }
                SOS= $"{orderQuantity}-{nameOrder} prepared";
                isRequest = false;
            }
            else
            {
                throw new Exception("No food is required for prepare!!!");
            }
            return SOS;
        }
    }
}
