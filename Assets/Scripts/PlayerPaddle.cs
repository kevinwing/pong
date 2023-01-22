using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction; // vector for x,y directional movement
    public Canvas canvasObj;    // reference to the Canvas object containing the help menu

    // Start is called before the first frame update
    void Start()
    {
        canvasObj.enabled = false; // set canvas to not show at game start
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) { // check if 'p' is pressed
            SetPauseState();
        } else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) { // check if 'w' pressed
            _direction = Vector2.up;
        // move paddle down
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { // check if 's' pressed
            _direction = Vector2.down;
        } else if (Input.GetKey(KeyCode.Escape)) { // check if 'escape' is pressed
            Application.Quit(); // quit game
        } else { // no movement if other conditions not met
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        // if player movement is detected, move the paddle in that direction
        if (_direction.sqrMagnitude != 0) {
            _rigidbody.AddForce(_direction * speed); // add movement in the chosen direction
        }
    }

    // when 'p' is pressed, determine current pause state and toggle accordingly
    private void SetPauseState()
    {
        // If game is currently paused, unpause
        if (Time.timeScale == 0.0f) {
            Time.timeScale = 1.0f; // sets game clock to normal
            canvasObj.enabled = false; // hide help menu
        } else { // pause game
            Time.timeScale = 0.0f; // sets game clock to 0, effectively pausing.
            canvasObj.enabled = true; // display help menu
        }
    }
}
