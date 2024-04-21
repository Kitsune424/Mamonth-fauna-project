using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTests : MonoBehaviour
{
    public void LoadMap()
    {
        Debug.Log("map load");
        UnityEngine.SceneManagement.SceneManager.LoadScene("mapTest");
    }

    public void LoadTest()
    {
        Debug.Log("test load");
        UnityEngine.SceneManagement.SceneManager.LoadScene("testTest");
    }
}
