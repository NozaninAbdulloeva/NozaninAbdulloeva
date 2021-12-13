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
        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee employee = new Employee();
        int totalmenu;
        string menu;
        object zakaz; 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                totalmenu = Convert.ToInt16(QuantityTextBox.Text);
                if (radioButton1.Checked)
                    menu = "Chicken";

                else if (radioButton2.Checked)
                    menu = "Egg";

                zakaz = employee.NewRequest(totalmenu, menu);
                inspactionLabel.Text = employee.Inspect(zakaz);
            }
            catch (FormatException)
            {
                QuantityTextBox.Clear();  
                MessageBox.Show("ERROR!  Enter the namber in the TEXTBOX!!!", "ERROR MIRROR");                
            }                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                zakaz= employee.CopyRequest();
                inspactionLabel.Text = employee.Inspect(zakaz);
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
                ResultList.Items.Add(employee.PrepareFood(zakaz));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }             
        }
    }
}
