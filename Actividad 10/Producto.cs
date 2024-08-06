using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    internal class Producto
    {

        public string Marca { get; set; }
        public string NumeroDeSerie { get; set; }
        public string Modelo { get; set; }

        public Producto(string marca, string numeroDeSerie, string modelo)
        {
            Marca = marca;
            NumeroDeSerie = numeroDeSerie;
            Modelo = modelo;
        }

        public virtual string MostrarInformacion()
        {
            return $"Marca: {Marca}, Número de Serie: {NumeroDeSerie}, Modelo: {Modelo}";
        }
    }
}
