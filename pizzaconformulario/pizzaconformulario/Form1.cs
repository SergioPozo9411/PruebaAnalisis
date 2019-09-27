using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaconformulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pizza = new Pizza();
            MessageBox.Show("Pizza creada");

            var refresco = new Refresco();
            pizza.Refresco = refresco; //si eliminas pizza el refresco aun hay y asi 
        }
    }
}
