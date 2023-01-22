using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    public Canvas canvasObj;
    // Start is called before the first frame update
    void Start()
    {
        // canvasObj = GetComponent<Canvas>();
        canvasObj.enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        // Move paddle up
        if (Input.GetKeyDown(KeyCode.P)) {
            SetPauseState();
        } else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            _direction = Vector2.up;
        // move paddle down
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            _direction = Vector2.down;
        // pause/unpause
        // quit game
        } else if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        // movement is zero
        } else {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0) {
            _rigidbody.AddForce(_direction * speed);
        }
    }

    private void SetPauseState()
    {
        // If game is currently paused, unpause
        if (Time.timeScale == 0.0f) {
            Time.timeScale = 1.0f;
            canvasObj.enabled = false;
            // SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            // SceneManager.SetActiveScene(SceneManager.GetSceneByName("Pong"));
        } else { // pause game
            Time.timeScale = 0.0f;
            canvasObj.enabled = true;
            // SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            // SceneManager.SetActiveScene(SceneManager.GetSceneByName("Pause"));
        }
    }
}
