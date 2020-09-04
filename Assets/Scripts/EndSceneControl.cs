using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneControl : MonoBehaviour
{
    public GameObject ShutDownText;
    public string nextscene;
    public GameObject LevelLoader;
    public Animator animator;
    public bool IsRunning;
    void Start()
    {
        StartCoroutine(ActivateText());
        IsRunning = true;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRunning)
        {
            transform.position += transform.forward * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.F))
        {
            animator.SetBool("Stopped", true);
            IsRunning = false;
            StartCoroutine(NextScene());
        }
    }
    IEnumerator ActivateText()
    {
        yield return new WaitForSeconds(9f);
        ShutDownText.SetActive(true);
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(2f);
        LevelLoader.GetComponent<LevelChanger>().FadeToLevel(nextscene);
    }
}
