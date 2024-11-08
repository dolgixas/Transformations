using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRotatingGrowingCube : MonoBehaviour
{
    [SerializeField]
    private float _movementSpeed = 5f;
    [SerializeField]
    private float _rotationSpeed = 50f;
    [SerializeField]
    private float _growthRate = 0.1f;

    private bool _isOperational = true;

    public bool IsOperational
    {
        get { return _isOperational; }
    }

    private void Update()
    {
        if (_isOperational)
        {
            Move();
            Rotate();
            Grow();
        }
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }

    private void Grow()
    {
        transform.localScale += new Vector3(_growthRate, _growthRate, _growthRate) * Time.deltaTime;
    }

    public void Break()
    {
        _isOperational = false;
    }

    public void Repair()
    {
        _isOperational = true;
    }
}
