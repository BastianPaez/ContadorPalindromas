using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrasePalindroma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TxtFrase_TextChanged(object sender, EventArgs e)
        {
            //contador de letras
            String frase = TxtFrase.Text.Replace(" ", "");
            int tope = 101;
            int NumeroFrase = frase.Length;

            for (int ConteoLetras = 0; ConteoLetras <= NumeroFrase; ConteoLetras++)
            {
                if (ConteoLetras == tope)
                {
                    ConteoLetras--;
                    MessageBox.Show("No se permite mas de 100 letras");
                    break;
                }
                CantidadLetras.Text = ConteoLetras.ToString();
            }
        }
        private void BtnValidar_Click(object sender, EventArgs e)
        {
            ContadorDePalindromas();
        }

        public bool SiEsPalindroma(string Palabras)
        {
            int Fin;
            bool EsPalindroma= true;

            if (!string.IsNullOrWhiteSpace(Palabras))
            {   
                if(Palabras.Length > 1)
                {int Mitad = Palabras.Length / 2;
                Fin = Palabras.Length - 1;
                for (int inicio = 0; inicio < Mitad; inicio++)
                {
                    if (Palabras[inicio] != Palabras[Fin])
                    {
                        EsPalindroma = false;
                        break;
                    }
                    Fin--;
                }
                    if (EsPalindroma)
                    {
                        return true;
                    }
                }
        }
            return false;
        }
            

        private int conteo = 0;

            private void ContadorDePalindromas()
            {
                string[] Frase = TxtFrase.Text.ToLower().Split(' ');

                this.conteo = 0;

                foreach (var UnaPalabra in Frase)
                {
                    if (SiEsPalindroma(UnaPalabra))
                    {
                        this.conteo++;
                    }
                }
                MessageBox.Show("son " + conteo+ " palabras Palindromas.");
            }



    }
}