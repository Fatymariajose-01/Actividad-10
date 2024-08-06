using Actividad_10;
public class Teléfono : Producto
{
    public int CantidadDeSim { get; set; }

    public Teléfono(string marca, string numeroDeSerie, string modelo, int cantidadDeSim)
        : base(marca, numeroDeSerie, modelo)
    {
        CantidadDeSim = cantidadDeSim;
    }

    public override string MostrarInformacion()
    {
        return base.MostrarInformacion() + $", Cantidad de SIMs: {CantidadDeSim}";
    }
}
