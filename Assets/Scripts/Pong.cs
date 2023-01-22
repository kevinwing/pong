using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pong : MonoBehaviour
{
    private Scene currentScene;
    // Start is called before the first frame update
    // void Awake()
    // {
        // Time.timeScale = 1.0f;
        // currentScene = SceneManager.GetActiveScene();
        // SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        // SceneManager.SetActiveScene(currentScene);
    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P)) {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Pause"));
            Time.timeScale = 0.0f;
        } else if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
