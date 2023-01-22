using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// parent class to the player and computer paddles
public class Paddle : MonoBehaviour
{
    public float speed = 10.0f; // set a speed multiplier
    protected Rigidbody2D _rigidbody; // reference available to child classes

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>(); // get a reference to the current objects rigidbody component
    }
}
