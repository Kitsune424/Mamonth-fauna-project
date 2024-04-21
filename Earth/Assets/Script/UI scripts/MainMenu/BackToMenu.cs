using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    public void LoadaMenu()
    {
        Debug.Log("Menu load");
        UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
}
