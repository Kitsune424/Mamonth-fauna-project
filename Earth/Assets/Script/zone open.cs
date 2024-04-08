using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoneopen : MonoBehaviour
{
    public Camera camera;
    public GameObject zone;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                zone.SetActive(true);
            }
        }
    }

    private void OnMouseDown()
    {
    }
}
