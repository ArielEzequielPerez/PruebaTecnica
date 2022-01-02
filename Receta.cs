using System.Collections.Generic;

class Receta{
    string nombre;
    public Dictionary<string, int> ingredientes = new Dictionary<string, int>();

    public Receta(string nombre){
        this.nombre = nombre;
    }
    public void AddIngrediente(string ingrediente, int cantidad){
        ingredientes.Add(ingrediente, cantidad);
    }
    public string getNombre(){
        return nombre;
    }
    /*puede ser preparada si la cocina tiene estock suficiente*/
    public bool PuedeSerPreparada(Cocina cocina){
        bool bandera =false;
        foreach(var unIngrediente in this.ingredientes){
            if(cocina.getStockIngrediente(unIngrediente.Key) < unIngrediente.Value){
                bandera = true;
                }
            }
            return bandera;
        }

    public bool Preparar(Cocina cocina){
        bool bandera= false;
        if(PuedeSerPreparada(cocina)){
            foreach(var unIngrediente in this.ingredientes){
                cocina.reducirCantidad(unIngrediente.Key, unIngrediente.Value);
                bandera = true;
            }
        }
        return bandera;
    }

    public Dictionary <string, int> ingredientesFaltantes (Cocina cocina){
        Dictionary<string, int> ingredientesFaltantes = new Dictionary<string, int>();
        foreach(var unIngrediente in this.ingredientes){
            if(cocina.getStockIngrediente(unIngrediente.Key) < unIngrediente.Value){
                ingredientesFaltantes.Add(unIngrediente.Key, unIngrediente.Value - cocina.getStockIngrediente(unIngrediente.Key));
            }
        }
        return ingredientesFaltantes;
    } 


}
            