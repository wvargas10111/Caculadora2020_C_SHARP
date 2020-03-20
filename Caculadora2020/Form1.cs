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

        //////////Aquí declaro las variables de instancia./////////////


        double operando1 = 0;//operador1 guardará el primer número. 
       
        String operacion = ""; //En el string operación guardo la operación que ha sido pulsada.

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0" && boton.Text != ",")
            {
                label1.Text = boton.Text; 
               
            }
            else
            {

                label1.Text = label1.Text + boton.Text;
            }

        }

        private void button17_Click (object sender, EventArgs e)//Borrado completo de ambas pantallas.
        {
            label1.Text = "0";
            label2.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e) //Aqui se guarda la operación (básica) pulsada.
        {
            Button boton = (Button)sender;
           
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0" ;
            
        }

        private void button11_Click(object sender, EventArgs e) //Operaciones básicas.
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            
            
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
                
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;

            } 
            else if (operacion == "/")
            {
                resultado = operando1 / operando2;
            
            }
           
            
                label1.Text = Convert.ToString(operando1 + operacion + operando2);
                label2.Text = Convert.ToString(resultado);
                
        }

        private void button18_Click(object sender, EventArgs e) //Borra el ultimo caracter.
        {
            if (label1.Text.Length == 1)
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }

        }

        private void button20_Click(object sender, EventArgs e) // Devuleve el % del nº pulsado.
        {
            label1.Text = Convert.ToString(Convert.ToDouble(label1.Text) / 100);
        }

        private void button19_Click(object sender, EventArgs e) //Devuelvela raíz cuadrada del nº pulsado.
        {
            if (Convert.ToString(Math.Sqrt(Convert.ToDouble(label1.Text))) == "NaN")
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(label1.Text)));
            }
        }

        private void button22_Click(object sender, EventArgs e) // Eleva a la potencia de 2 el nº pulsado.
        {
            label1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(label1.Text), 2));
        }

        private void button23_Click(object sender, EventArgs e) // Eleva a la potecia de 3 el nº pulsado.
        {
            label1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(label1.Text), 3));
        }

        private void button21_Click(object sender, EventArgs e) //Devuelve el negativo del nº pulsado. 
        {
            label1.Text = Convert.ToString(-1 * Convert.ToDouble(label1.Text));
        }
    }
    } 




