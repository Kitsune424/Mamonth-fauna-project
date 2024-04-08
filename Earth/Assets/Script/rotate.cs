using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [Range(500, 1000)] public float rotationSpeed = 100.0f;


    // Start is called before the first frame update
    void Start() { }
    
    // Update is called once per frame
    void Update()
    {
        inputSetup();
    }

    private void inputSetup()
    {
        if (Input.GetMouseButton(0)) // Проверяем, нажата ли левая кнопка мыши
        {
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime; // Получаем положение курсора по оси X
            float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime; // Получаем положение курсора по оси Y

            transform.Rotate(Vector3.up, -mouseX, Space.World); // Вращаем сферу вокруг оси x
            //transform.Rotate(Vector3.right, yrotation, Space.World); // Вращаем сферу вокруг оси Y
        }
    }
}
