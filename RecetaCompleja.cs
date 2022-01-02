using System.Collections.Generic;
using System.Linq;

class RecetaCompleja : Receta
{
    public RecetaCompleja(string nombre) : base(nombre)
    {
    }
    List<string> habilidades = new List<string>();

    public void AddHabilidad(string habilidad)
    {
        if(!this.EstaEnlaLista(habilidad)){
            this.habilidades.Add(habilidad);
        }
    }

    public bool EstaEnlaLista(string habilidad)
    {
        return habilidades.Contains(habilidad);
    }

    public new bool PuedeSerPreparada(Cocina cocina) => base.PuedeSerPreparada(cocina) && this.CumpleConHabilidad(cocina);

    public bool CumpleConHabilidad(Cocina cocina) => habilidades.All(habilidad => cocina.tieneHabilidad(habilidad));
}