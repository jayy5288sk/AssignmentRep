using System;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField] private float _tankSpeed;
    [SerializeField] private Transform _movingPoint;
    [SerializeField] private float _tankRotateSpeed;
    
    private void Update()
    {
        Move();
        //MoveToPoint();
        TankRotate();
    }

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(x, 0, z);
        
        transform.position += movement * _tankSpeed * Time.deltaTime;
    }

    private void MoveToPoint()
    {
        //transform.position = Vector3.MoveTowards
        transform.position = Vector3.Lerp
        (
            transform.position, 
            _movingPoint.position, 
            _tankSpeed * Time.deltaTime
        );
    }

    private void TankRotate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, _tankRotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down, _tankRotateSpeed * Time.deltaTime);
        }
    }
}
