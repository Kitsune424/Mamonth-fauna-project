using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsButtons : MonoBehaviour
{
    public GameObject zone;

    public void ExitButton()
    {
       zone.SetActive(false);
    }

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }
}
