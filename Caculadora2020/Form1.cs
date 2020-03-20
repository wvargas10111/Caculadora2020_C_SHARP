using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculadora2020
{
    public partial class Form1 : Form
    {

        //Aquí declaro las variables de instancia

        //operador1 guardará el primer número 
        double  operando1 = 0;
        //En el string operación guardp la operación que ha sido pusada
        String operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else
            {
              
                label1.Text = label1.Text + boton.Text;
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
         }

        private void button11_Click(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            if(operacion == "+")
            {
                resultado = operando1 + operando2;
            }else if(operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            label1.Text = Convert.ToString(resultado);
        }
    }
}
