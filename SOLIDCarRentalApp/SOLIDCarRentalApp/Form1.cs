using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLIDCarRentalApp
{
    public partial class Form1 : Form
    {
        string myObject =null;
        public static string outputFinal = "";
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightSeaGreen;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if( textBox1.Text == "Car" || textBox1.Text == "car" || textBox1.Text == "CAR")
            {
                myObject = "car";
                string[] myCars = { "Kia Sportage", "Mercedes", "Limousine" };
                checkedListBox1.Items.AddRange(myCars);

                // Changes the selection mode from double-click to single click.
                checkedListBox1.CheckOnClick = true;
            }
            else if (textBox1.Text == "Bike" || textBox1.Text == "bike" || textBox1.Text == "BIKE")
            {
                myObject = "bike";
                string[] myBikes = { "Sports", "Touring", "Cruiser" };
                checkedListBox1.Items.AddRange(myBikes);

                // Changes the selection mode from double-click to single click.
                checkedListBox1.CheckOnClick = true;

            }
            else
            {
                MessageBox.Show("Enter a valid input", "ERROR");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                string featuresOutput = "";
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {

                    if (myObject == "bike")
                    {
                        featuresOutput = featuresOutput + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n" +Factory.createObjectOfBike(x + 1).Features();
                      

                    }
                    else if (myObject == "car")
                    {
                        featuresOutput = featuresOutput + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n" + Factory.createObjectOfCar(x + 1).Features();

                    }

                    featuresOutput = featuresOutput + "\n";
                }
                MessageBox.Show(featuresOutput, "Features");
            }

           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
            {

                outputFinal = outputFinal + "Rented Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "   ";

            }
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            

        }
    }
}
