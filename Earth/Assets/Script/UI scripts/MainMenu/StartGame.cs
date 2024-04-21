using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
  public void LoadaGame()
    {
        Debug.Log("Game load");
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
