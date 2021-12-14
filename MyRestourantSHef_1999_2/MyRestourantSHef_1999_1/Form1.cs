using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRestourantSHef_1999_1
{
    public enum Menu { Chicken, Egg, NoDrink, Tea, Coffee, RC_Cola, PepsiCola }
    public enum Drink { NoDrink = 2, Tea, Coffee, RC_Cola, PepsiCola }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee employee = new Employee();
        Server server = new Server();
        private int chickenQuantity;
        private  int eggQuantity;
        private int drink;
        private Drink typeOfDrink;
        private bool isResive;
        private bool isSend;

        public Drink Drink(int drink)
        {
            switch (drink)
            {
                case 0:
                    typeOfDrink = MyRestourantSHef_1999_1.Drink.NoDrink;
                    break;
                case 1:
                    typeOfDrink = MyRestourantSHef_1999_1.Drink.Tea;
                    break;
                case 2:
                    typeOfDrink = MyRestourantSHef_1999_1.Drink.Coffee;
                    break;
                case 3:
                    typeOfDrink = MyRestourantSHef_1999_1.Drink.RC_Cola;
                    break;
                case 4:
                    typeOfDrink = MyRestourantSHef_1999_1.Drink.PepsiCola;
                    break;                                  
                     
            }
            return typeOfDrink;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResultList.Items.Clear();    
         try
         {
                chickenQuantity = int.Parse(QuantityChickenTextBox.Text);
                eggQuantity = int.Parse(QuantityEggTextBox.Text);
                drink = DrinkComboBox.SelectedIndex;

                if (chickenQuantity==0 && eggQuantity==0 && DrinkComboBox.Text=="NoDrink")
                {
                    throw new Exception("No Order!!!");
                }
                else
                {
                    isResive = true;
                    server.ReceiveRequest(chickenQuantity, eggQuantity, Drink(drink));
                }            
              }
            catch (Exception ex)
            {               
                MessageBox.Show(ex.Message, "ERROR MIRROR");                
           }                    
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            try
            {
                if (isResive)
                {
                    server.SendAll();
                    isSend = true;
                    isResive = false; 
                }
                else
                {
                    throw new Exception("Baroi firistodan zakaz nest!!!");
                }              
                //inspactionLabel.Text = ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }       
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            try
            {
                if (isSend)
                {
                    string[] result = server.ServePrepared();
                    foreach (var natija in result)
                    {
                        ResultList.Items.Add(natija);
                    }
                    isSend = false;
                }
                else
                {
                    throw new Exception("Baroi ovardan xurok nest!!!");
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }            
        }
    }
}
