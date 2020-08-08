using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject Page1;
    public GameObject Page2;
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Maze1()
    {
        SceneManager.LoadScene("Maze1");
    }
    public void Maze2()
    {
        SceneManager.LoadScene("Maze2");
    }
    public void Maze3()
    {
        SceneManager.LoadScene("Maze3");
    }
    public void Maze4()
    {
        SceneManager.LoadScene("Maze4");
    }
    public void Maze5()
    {
        SceneManager.LoadScene("Maze5");
    }
    public void Maze6()
    {
        SceneManager.LoadScene("Maze6");
    }
    public void Maze7()
    {
        SceneManager.LoadScene("Maze7");
    }
    public void Maze8()
    {
        SceneManager.LoadScene("Maze8");
    }
    public void Maze9()
    {
        SceneManager.LoadScene("Maze9");
    }
    public void Maze10()
    {
        SceneManager.LoadScene("Maze10");
    }
    public void NextPage()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);
    }
    public void PreviousPage()
    {
        Page1.SetActive(true);
        Page2.SetActive(false);
    }
    public void Back()
    {
        SceneManager.LoadScene("RegularMenu");
    }
    public void BackBlue()
    {
        SceneManager.LoadScene("BlueModeMenu");
    }
    public void Maze1Blue()
    {
        SceneManager.LoadScene("Maze1Blue");
    }
    public void Maze2Blue()
    {
        SceneManager.LoadScene("Maze2Blue");
    }
    public void Maze3Blue()
    {
        SceneManager.LoadScene("Maze3Blue");
    }
    public void Maze4Blue()
    {
        SceneManager.LoadScene("Maze4Blue");
    }
    public void Maze5Blue()
    {
        SceneManager.LoadScene("Maze5Blue");
    }
}
