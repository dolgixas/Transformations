using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere1 : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    public float Speed
    {
        get { return speed; }
        set { speed = Mathf.Max(0, value); }
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
