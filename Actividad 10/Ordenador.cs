using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    internal class Ordenador:Producto
    {
        public int TamanoRam { get; set; } 

        public Ordenador(string marca, string numeroDeSerie, string modelo, int tamanoRam)
            : base(marca, numeroDeSerie, modelo)
        {
            TamanoRam = tamanoRam;
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $", Tamaño de RAM: {TamanoRam} GB";
        }
    }
}
