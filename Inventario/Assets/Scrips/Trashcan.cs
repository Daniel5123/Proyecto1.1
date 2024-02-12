using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcan : MonoBehaviour
{
    //Elimina los objetos cuando colisionan con el bote de basura
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != null)
        {
            Destroy(collision.gameObject);
        }
    }
}
