using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETOK
{
    class tempo
    {
        int minutos = -1;

        public int GetTempo()
        {
            return minutos;
        }

        public void setTempo(string tempoS)
        {

            try
            {
                this.minutos = Convert.ToInt32(tempoS);
            }


            catch
            {
                MessageBox.Show("Inserir minutos");
            }

        }
    }
}
