using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingCapsule : MonoBehaviour
{
    [SerializeField] 
    private float growthSpeed = 1f;

    public float GrowthSpeed
    {
        get { return growthSpeed; }
        set { growthSpeed = Mathf.Max(0, value); } 
    }

    void Update()
    {
        transform.localScale += Vector3.one * growthSpeed * Time.deltaTime;
    }
}
