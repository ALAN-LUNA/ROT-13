using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROT_13_V
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            string msj = textBox1.Text;
            string Value = msj;

            Value = Rot13.Transform(Value);

            Richtext.Text = Value;

        }
        public static class Rot13
        {
            public static string Transform(string value)
            {
                char[] Arreglo = value.ToCharArray();
                for (int i = 0; i < Arreglo.Length; i++)
                {
                    int Numero = (int)Arreglo[i];

                    if (Numero >= 'a' && Numero <= 'z')
                    {
                        if (Numero > 'm')
                        {
                            Numero -= 13;
                        }
                        else
                        {
                            Numero += 13;
                        }
                    }

                    else if (Numero >= 'A' && Numero <= 'Z')
                    {
                        if (Numero > 'M')
                        {
                            Numero -= 13;
                        }
                        else
                        {
                            Numero += 13;
                        }
                    }
                    Arreglo[i] = (char)Numero;
                }
                return new string(Arreglo);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
