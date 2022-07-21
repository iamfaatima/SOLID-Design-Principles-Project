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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            listBox1.Items.Add(Form1.outputFinal);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
