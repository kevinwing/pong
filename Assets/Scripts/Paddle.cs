using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
