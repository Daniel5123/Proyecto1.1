using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    //Se asignan valores en la clase base para despues actulizarlos en la clase derivada
    public string Nombre;
    public int Daño;
    public int Durabilidad;
    public string Descripcion;
    public int regeneracionVida;
    public string Rareza;
    public string Habilidad;
    public Sprite swordSprite;

    //Imprime el mensaje en consola
    public virtual void Objetos()
    {
        Debug.Log($"Nombre: {Nombre}, Daño: {Daño}, Durabilidad: {Durabilidad}, Descripcion: {Descripcion}, Regeneracion de Vida: {regeneracionVida}, Rareza: {Rareza}, Habilidad: {Habilidad}");
    }
}
