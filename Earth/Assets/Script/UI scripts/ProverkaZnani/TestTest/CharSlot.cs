using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharSlot : MonoBehaviour, IDropHandler
{
    public string slotName;
    public bool correctChar = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            Debug.Log("ObjDropped");
            GameObject dropped = eventData.pointerDrag;
            DraggableChar draggableChar = dropped.GetComponent<DraggableChar>();

            draggableChar.parentAfterDrag = transform;

            if (draggableChar.CharName == slotName)
                correctChar = true;
        }

        if (slotName == "panel")
        {
            Debug.Log("ObjDropped");
            GameObject dropped = eventData.pointerDrag;
            DraggableChar draggableChar = dropped.GetComponent<DraggableChar>();

            draggableChar.parentAfterDrag = transform;

            if (draggableChar.CharName == slotName)
                correctChar = true;
        }
    }
}
