using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _speed = 1000;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Platform")
        {
            _rigidbody.AddForce(Vector3.up * _speed);
            _speed -= 100;
        }
    }
}
