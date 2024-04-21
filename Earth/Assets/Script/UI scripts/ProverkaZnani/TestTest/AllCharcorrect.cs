using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllCharcorrect : MonoBehaviour
{
    public CharSlot[] charSlots;
    public GameObject correctWindow;

    private void Update()
    {
        bool wordCorrect = true;

        foreach (CharSlot charslot in charSlots)
        {
            if (charslot.correctChar == false)
            {
                wordCorrect = false;
                break;
            }
        }

        if (wordCorrect == true)
            correctWindow.SetActive(true);
    }
}
