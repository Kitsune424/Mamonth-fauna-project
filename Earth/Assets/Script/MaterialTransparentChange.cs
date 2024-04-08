using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MaterialTransparentChange : MonoBehaviour
{
    [SerializeField] public Button button;
    [SerializeField] public TextMeshProUGUI buttonText;
    [SerializeField] public Material Earth_now;
    [SerializeField] public Material Earth_gp;
    public Color transparent;
    public Color notransparent;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void ChangeColor()
    {
        if (buttonText.text == "Земля в наше время")
        {
            Earth_now.color = transparent;
            Earth_gp.color = notransparent;
            buttonText.text = "Земля в ледниковый период";
        }
        else
        {
            Earth_now.color = notransparent;
            Earth_gp.color = transparent;
            buttonText.text = "Земля в наше время";
        }
    }
}
