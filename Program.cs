using System;

namespace restaurante_El_FIFI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecetaCompleja tortaOpera = new RecetaCompleja("torta opera");
            tortaOpera.AddIngrediente("harina", 300);
            tortaOpera.AddIngrediente("manteca", 300);
            tortaOpera.AddIngrediente("huevo", 3);
            Cocina unaCocina = new Cocina("cocina", 4);
            tortaOpera.AddHabilidad("pasteleria");
            tortaOpera.AddHabilidad("cocina francesa");
            tortaOpera.Preparar(unaCocina);
        }
    }
}
