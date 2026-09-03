using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMover : MonoBehaviour
{
    private float _movePerSecond;

    public void SetMove(float speed)
    {
        _movePerSecond = speed;
    }
    
    private void Update()
    {
        BeltMoverStart();
    }

    private void BeltMoverStart()
    {
        transform.position += transform.forward * _movePerSecond * Time.deltaTime;
    }
}
