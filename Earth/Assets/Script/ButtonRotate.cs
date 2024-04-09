using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonRotate : MonoBehaviour
{
    public GameObject objectToRotate;
    [Range(100, 1000)]public float rotationSpeed = 100f;
    bool rotateRight = false;
    bool rotateLeft = false;

    void Start() { }

    public void Update() 
    {
        if (rotateLeft)
        {
            objectToRotate.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if (rotateRight)
        {
            objectToRotate.transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
        }
    }

    public void RotateleftCheck(bool _rotateLeft)
    {
        rotateLeft = _rotateLeft;
    }

    public void RotaterightCheck(bool _rotateRight)
    {
        rotateRight = _rotateRight;
    }
}
