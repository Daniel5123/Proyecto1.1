using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Front : Items
{
    //Llama los valores de la main y actualiza los agregados en la clase derivada
    private void Awake()
    {
        Nombre = "Pechera de diamante";
        Daño = 10;
        Durabilidad = 1000;
        Descripcion = "Esta pechera esta hecha por diamantes la cual te cubre de todo";
        regeneracionVida = 0;
        Rareza = "Legendaria";
        Habilidad = "Porteccion";
        base.Objetos();
    }
    //Imprime el mensaje en consola

    public override void Objetos()
    {
        Debug.Log("Nombre:" + Nombre + "Daño:" + Daño + "Durabilida:" + Durabilidad + "Descripcion:" + Descripcion + "Regeneracion de Vida:" + regeneracionVida + "Rareza:" + Rareza + "Habilidad:" + Habilidad);
    }
}
