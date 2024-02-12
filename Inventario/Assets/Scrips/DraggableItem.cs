using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;
    
    //Al presionar el clic el objeto es seleccionado 
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Su funcion es hacer que el objeto seleccionado no se vaya para atras de los canvas haciedo que siempre sea visible el item y tambien ayuda a poder pasarlo entre hueco y hueco 
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }
    
    //Al mantener el clic el objeto viaja con el mouse
    public void OnDrag(PointerEventData eventData)
    {
        
        transform.position = Input.mousePosition;
    }
    //Al soltar el clic el objeto regresa al lugar en el que estaba anteriormente
    public void OnEndDrag(PointerEventData eventData)
    {
        
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
    
}
