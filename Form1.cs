using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca
{

    public partial class Biblioteca : Form
    {

        public Biblioteca()
        {
            InitializeComponent();
        }

        public static int lineas;
        public static string[,] bdllibres = new string[10, 3];
        public static string llistatLinees = "";

        private void Mostra_tots_Click(object sender, EventArgs e)
        {

            Llibres_tots.Clear();
            Llibres_tots.Visible = true;
            Llegeix_text();
            MostraText();


        }

        private void Mostra_un_Click(object sender, EventArgs e)
        {
            Llibres_tots.Visible = false;

        }

        private void Llibres_tots_TextChanged(object sender, EventArgs e)
        {

        }

        private void Llegeix_text()
        {

            string[] contenido = System.IO.File.ReadAllLines(@"Llibres.txt");

            lineas = contenido.Length;


            for (int x = 0; x < lineas; x++)
            {
                String[] libro = contenido[x].Split(';');

                for (int y = 0; y < 3; y++)
                {
                    bdllibres[x, y] = libro[y];
                }
            }

        }
        private void MostraText()
        {
            llistatLinees = "";
            for (int x = 0; x < lineas; x++)
            {
                llistatLinees += "[" + (x + 1) + "]";
                llistatLinees += "Nom: " + bdllibres[x, 0] + " | ";
                llistatLinees += "Autor: " + bdllibres[x, 1] + " | ";
                llistatLinees += "Any: " + bdllibres[x, 2] + " | ";

                llistatLinees += Environment.NewLine;
            }
            Llibres_tots.Text = llistatLinees;
        }

    }
}
