using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado
{
    public partial class Form1 : Form
    {
        Dado dado1;
        Dado dado2;
        public Form1()
        {
            InitializeComponent();
            dado1 = new Dado();
            dado2 = new Dado();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            int[] suma = new int[6];
            //123456
            //012345
            for (int i = 0; i < 100; i++)
            {
                int lanzamiento = dado1.lanzar(); //acomodo del vec
                suma[lanzamiento-1]++;
            }

            for (int i = 0; i < suma.Length; i++)
                txtMostrar.Text += "La cara " + (i + 1) + " Cayó: " + suma[i].ToString() + Environment.NewLine;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int[] suma = new int[11];
            //23456789012
            //01234567890
            for(int i = 0; i < 100; i++)
            {
                int x = dado1.lanzar() + dado2.lanzar();
                suma[x-2]++;
            }

            for(int i = 0; i < suma.Length; i++)
            {
                txtMostrar.Text += "La suma " + (i + 2) + " ocurrio: " + suma[i].ToString() + Environment.NewLine;
            }
        }
    }
}
