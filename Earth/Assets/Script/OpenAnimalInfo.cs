using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using menuchek;
using static UnityEngine.GraphicsBuffer;

public class OpenAnimalInfo : MonoBehaviour
{
    public GameObject zone;
    private GameObject menu;

    private void Awake()
    {
        menu = GameObject.FindWithTag("menu").GetComponent<MenuCheck>().ingameMenu;
    }
    private void OnMouseUpAsButton()
    {
        if (!menu.active)
        {
            Debug.Log("Menu desable");
            if (zone != null)
            {
                zone.SetActive(true);
            }
        }
    }
}
