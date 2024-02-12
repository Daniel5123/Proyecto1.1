using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beak : Items
{
    //Llama los valores de la main y actualiza los agregados en la clase derivada
    private void Awake()
    {
        Nombre = "Pico de Diamante";
        Daño = 20;
        Durabilidad = 400;
        Descripcion = "Esta arma esta hecha por menas de diamante";
        regeneracionVida = 0;
        Rareza = "Legendaria";
        Habilidad = "Picotazo";
        base.Objetos();
    }
    //Imprime el mensaje en consola

    public override void Objetos()
    {
        Debug.Log("Nombre:" + Nombre + "Daño:" + Daño + "Durabilida:" + Durabilidad + "Descripcion:" + Descripcion + "Regeneracion de Vida:" + regeneracionVida + "Rareza:" + Rareza + "Habilidad:" + Habilidad);
    }

}
