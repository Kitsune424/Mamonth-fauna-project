using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAnimalInfo : MonoBehaviour
{
    public GameObject zone;

    private void Update()
    {
    }

    private void OnMouseUpAsButton()
    {
        if (zone != null)
        {
            zone.SetActive(true);
        }
    }
}
