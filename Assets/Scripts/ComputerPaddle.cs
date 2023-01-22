using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball; // publicly accessable reference to the balls rigidbody

    // runs based on number of physics related actons are applied
    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f) // check if ball is moving to the right
        {
            if (this.ball.position.y > this.transform.position.y) { // check if ball is moving on an upward rout3
                _rigidbody.AddForce(Vector2.up * this.speed); // increase height
            } else if (this.ball.position.y < this.transform.position.y) { // check if ball is moving down
                _rigidbody.AddForce(Vector2.down * this.speed); // decrease height
            }
        } else { // ball is moving to the left
            if(this.transform.position.y > 0.0f) { // check for ball moving down
                _rigidbody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) { // ball is moving up
                _rigidbody.AddForce(Vector2.up  * this.speed);
            }
        }
    }
}
