using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
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
