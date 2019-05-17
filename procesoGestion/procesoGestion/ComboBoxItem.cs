using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesoGestion
{
    class ComboBoxItem
    {
        public String texto { get; set; }
        public int valor { get; set; }

        public ComboBoxItem (String texto, int valor)
        {
            this.texto = texto;
            this.valor = valor;
        }

        public override string ToString()
        {
            return texto;
        }
    }
}
