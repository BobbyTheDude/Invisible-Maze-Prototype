using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void Play()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void BluePlay()
    {
        SceneManager.LoadScene("Maze1Blue");
    }
    public void BlueLevelSelect()
    {
        SceneManager.LoadScene("BlueLevelSelect");
    }
}
