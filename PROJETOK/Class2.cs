using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETOK
{
    class Class2
    {
        string letras;

        public string GetString()
        {
            return letras;
        }

        public void setFrases(string frase)
        {
            try
            {
                this.letras = Convert.ToString(frase);
               
            }
            catch 
            {

                MessageBox.Show("Preencha os campos corretamente");
            }

        }
    }

}

   

