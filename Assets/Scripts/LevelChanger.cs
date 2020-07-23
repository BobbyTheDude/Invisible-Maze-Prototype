using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    public string LoadingLevel;


    // Update is called once per frame
    void Update()
    {
        
    }
    public void FadeToLevel(string LevelToLoad)
    {
        LoadingLevel = LevelToLoad;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(LoadingLevel);
    }
}
