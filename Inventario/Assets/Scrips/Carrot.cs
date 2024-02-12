using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : Items
{
    //Llama los valores de la main y actualiza los agregados en la clase derivada
    private void Awake()
    {
        Nombre = "Zanahoria";
        Daño = 5;
        Durabilidad = 10;
        Descripcion = "Una zanahoria cultivada por ti mismo";
        regeneracionVida = 30;
        Rareza = "Normal";
        Habilidad = "Velocidad";
        base.Objetos();
    }
    //Imprime el mensaje en consola

    public override void Objetos()
    {
        Debug.Log("Nombre:" + Nombre + "Daño:" + Daño + "Durabilida:" + Durabilidad + "Descripcion:" + Descripcion + "Regeneracion de Vida:" + regeneracionVida + "Rareza:" + Rareza + "Habilidad:" + Habilidad);
    }
}
