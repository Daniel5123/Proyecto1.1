using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.EventSystems;


public class InventorySlot : MonoBehaviour, IDropHandler
{
    //Funciona para podder dejar el item en el hueco que prefieras 
    public void OnDrop(PointerEventData eventData)
    {
        //Sirve para que el item no este en dos mismos huecos si hay uno ocupado
        if (transform.childCount == 0)
        {
            //Funciona para podder dejar el item en el hueco que prefieras
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;
        }
    }
}
