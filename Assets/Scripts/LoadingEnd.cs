using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingEnd : MonoBehaviour
{
    public float LoadTime;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        StartCoroutine(EndLoad());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator EndLoad()
    {
        yield return new WaitForSeconds(LoadTime);
        SceneManager.LoadScene("MainMenu");
    }
}
