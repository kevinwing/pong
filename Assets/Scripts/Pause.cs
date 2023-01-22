using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private Scene currentScene;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P)) {
            // currentScene = GetSceneByName("Pong");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Pong"));
            Time.timeScale = 1.0f;
        }
    }
}
