using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MaterialTransparentChange : MonoBehaviour
{
    [SerializeField] public Button button;
    [SerializeField] public TextMeshProUGUI buttonText;
    [SerializeField] public GameObject Earth_now;
    [SerializeField] public GameObject Earth_gp;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void ChangeColor()
    {
        if (buttonText.text == "Земля в наше время")
        {
            Earth_gp.SetActive(false);
            Earth_now.SetActive(true);
            buttonText.text = "Ледниковый пероид";
        }

        else
        {
            Earth_gp.SetActive(true);
            Earth_now.SetActive(false);
            buttonText.text = "Земля в наше время";
        }
    }
}
