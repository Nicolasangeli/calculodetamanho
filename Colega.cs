using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AulaOrientacao
{
    public class Colega
    {
        public string nome;
        public double altura;
        public int idade;

        public void exibir()
        {
            if (altura <= 1.50)
            {
                MessageBox.Show("Meu coleguinha se chama" +nome+ "e é um gnomo");
            }
            else
            {
                if(altura>1.50 && altura<=1.60)
                {
                    MessageBox.Show("Minion");
                }
                else
                {
                    if(altura>1.60 && altura<=1.70)
                    {
                        MessageBox.Show("OK");
                    }
                    else
                    {
                        MessageBox.Show("Melhor que OK");
                    }
                }

            }



        }


    }
}
