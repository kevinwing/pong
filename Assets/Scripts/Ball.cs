using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 300.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>(); // get reference to the Rigidbody2D of the Ball
    }
    // called before first frame is rendered
    private void Start()
    {
        AddStartingForce();
    }

    // choose the starting direction of the ball to add some randomness
    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x,y);
        _rigidbody.AddForce(direction * this.speed);
    }
}
