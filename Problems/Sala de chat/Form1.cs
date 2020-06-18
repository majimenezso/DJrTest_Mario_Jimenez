using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Sala_de_chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            string palabra = txt1.Text;
            MessageBox.Show("" + Validar(palabra));
        }

        public static bool Validar(string entrada){

            bool res = false;

            try
            {
                
                    char[] charUtilitzats = { };
                    char caracter = ' ';
                    int veces = 0;
                    bool val = false;
                    
              

                        for (int x = 0; x < entrada.Length; x++)
                        {

                            for (int y = 0; y < entrada.Length; y++)
                            {

                                caracter = entrada[x];

                                for (int z = 0; z < charUtilitzats.Length; z++)
                                {
                                    if (caracter == charUtilitzats[z])
                                    {
                                        val = true;
                                        break;
                                    }
                                    else
                                    {
                                        charUtilitzats[y] = caracter;
                                        veces++;
                                    }
                                }



                                if (caracter == entrada[y] && val != true)
                                {
                                    veces++;
                                    val = false;
                                }
                            }

                            if (val != true)
                            {
                               
                             
                            veces = 0;
                            res = true;


                        }
                            }
                        

            }catch(Exception)
            {



            } 

            return res;
         }
    }
}














