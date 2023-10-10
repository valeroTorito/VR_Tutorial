using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    // Скорость вращения мишени
    public float rotationSpeed = 50.0f;

    void Update()
    {
        // Вращаем мишень вокруг оси Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
