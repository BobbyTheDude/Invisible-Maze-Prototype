using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayRegular()
    {
        SceneManager.LoadScene("RegularMenu");
    }
    public void BlueMode()
    {
        SceneManager.LoadScene("BlueModeIntro");
    }
    public void DarkMode()
    {
        SceneManager.LoadScene("DarkModeMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
