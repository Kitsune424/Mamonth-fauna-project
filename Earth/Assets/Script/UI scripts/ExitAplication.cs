using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ExitAplication : MonoBehaviour
{
    public GameObject windowToClose;

    public void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }

    public void CloseWindow ()
    {
        windowToClose.SetActive(false);
    }

    public void OpenWindow()
    {
        windowToClose.SetActive(true);
    }
}
