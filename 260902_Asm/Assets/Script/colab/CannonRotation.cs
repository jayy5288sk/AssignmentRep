using System;
using UnityEngine;

public class CannonRotation : MonoBehaviour
{
    [SerializeField] private float _cannonRotateSpeed;

    private void Update()
    {
        CannonRotate();
    }

    private void CannonRotate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.up, _cannonRotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(Vector3.down, _cannonRotateSpeed * Time.deltaTime);
        }
    }
}
