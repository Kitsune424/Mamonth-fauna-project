using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour, IDropHandler
{
    public bool correctAnswer = false;
    public GameObject correct;
    public GameObject incorrect;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ObjDropped");

        GameObject dropped = eventData.pointerDrag;
        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();

        if (correctAnswer)
        {
            draggableItem.parentAfterDrag = transform;
            correct.SetActive(true);
        }
        else
            incorrect.SetActive(true);
    }
}
