using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSize_auto : MonoBehaviour
{
    private Image image;
    public float width = Screen.width;
    public float height = Screen.height;

    // Start is called before the first frame update
    void Start()
    {
        image.rectTransform.sizeDelta = new Vector2(width, height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
