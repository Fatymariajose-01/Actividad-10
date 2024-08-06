using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    internal class Tablet:Producto
    {
        public bool TieneCelular { get; set; }

        public Tablet(string marca, string numeroDeSerie, string modelo, bool tieneCelular)
            : base(marca, numeroDeSerie, modelo)
        {
            TieneCelular = tieneCelular;
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $", Tiene Celular: {TieneCelular}";
        }
    }
}
