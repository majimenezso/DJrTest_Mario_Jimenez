using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitalización
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //evento del boton 
        private void btn1_Click(object sender, EventArgs e)
        {
            //se guardar la palabra ingresada
            string palabra = t1.Text;
            //expresion regular para entradas con numeros
            bool valNum = Regex.IsMatch(palabra, @"^[a-zA-Z]+$");
            //se verifica que la entrada sea distinta de la expresion regular de letras
            if (!valNum)
            {
                // se muestra el menaje y se limpian los campos
                MessageBox.Show("la entrada debe ser solo palabras");
                t1.Text = "";
            }
            else
            {
                //se muestra el mensaje
                MessageBox.Show(Form1.Capitalizacion(palabra));

            }


         
        }
        //funcion para la capitalizacion
        public static String Capitalizacion(String str)
        {
            //se retorna la expresion si es nula
            if (str == null)
            {
                return str;
            }
            else
            {// se retorna la primera letra en mayuscula de la palabra ingresada
                return str.Substring(0, 1).ToUpper() + str.Substring(1);
            }

        
        }

    }
}
