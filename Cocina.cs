using System;
using System.Collections.Generic;

class Cocina
{

    public string nombre { get; set; }
    public int experiencia { get; set;}

    Dictionary<string, int> Ingredientes = new Dictionary<string, int>();

    List<string> habilidades = new List<string>();
    private string nombre1;

    public void addIngredientes(string ingrediente, int cantidad)
    {
        Ingredientes.Add(ingrediente, cantidad);
    }

    public Cocina(string nombre, int experiencia)
    {
        this.nombre = nombre;
        this.experiencia = experiencia;
    }
    public string getNombre()
    {
        return nombre;
    }


    public int getExperiencia()
    {
        return experiencia;
    }

    public bool tieneHabilidad(string habilidad)
    {
        return habilidades.Contains(habilidad);
    }

    public int getStockIngrediente(string ingrediente)
    {
        int valor = 0;
        foreach (var unIngrediente in this.Ingredientes)
        {
            if (unIngrediente.Key == ingrediente)
            {
                valor = unIngrediente.Value;
            }
        }
        return valor;
    }
    public void reducirCantidad(string ingrediente, int cantidad)
    {
        foreach (var unIngrediente in this.Ingredientes)
        {
            if (unIngrediente.Key == ingrediente)
            {
                this.Ingredientes[unIngrediente.Key] = unIngrediente.Value - cantidad;

            }
        }
    }


}