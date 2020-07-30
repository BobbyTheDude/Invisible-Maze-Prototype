using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndLoad());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator EndLoad()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("MainMenu");
    }
}
