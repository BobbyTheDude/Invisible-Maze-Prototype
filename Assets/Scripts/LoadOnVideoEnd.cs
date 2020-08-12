using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnVideoEnd : MonoBehaviour
{
    public float VideoDurationSeconds;
    public float TimeRemaining;
    public string NextScene;

    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = VideoDurationSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        TimeRemaining -= Time.deltaTime;
        if (TimeRemaining < 0f)
        {
            SceneManager.LoadScene(NextScene);
        }
    }
}
