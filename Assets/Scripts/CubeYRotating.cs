using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeYRotating : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 50f;

    public float RotationSpeed
    {
        get { return rotationSpeed; }
        set { rotationSpeed = Mathf.Max(0, value); }
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
