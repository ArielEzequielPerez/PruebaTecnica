using System;
using System.Collections.Generic;

class Restaurante{
    List<Cocina> cocinas = new List<Cocina>();
    List<Receta> recetas = new List<Receta>();

    /*public restaurante(){}*/
    public void addRestaurante(Cocina cocina){
        cocinas.Add(cocina);
    }
    public void addReceta(Receta receta){
        recetas.Add(receta);
    }

    public List<String> metodoMalNombrado(){
        List<String> lista = new List<String>();
        foreach(Receta r in this.recetas){
            bool variable = false;
            foreach(Cocina c in this.cocinas){
                variable = variable || r.Preparar(c);
                }
                if(variable){
                    lista.Add(r.getNombre());
                }
        }
        return lista;
    }
}