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
        SceneManager.LoadScene("CutScene1");
    }
    public void Maze2()
    {
        SceneManager.LoadScene("Cutscene2");
    }
    public void Maze3()
    {
        SceneManager.LoadScene("Cutscene3");
    }
    public void Maze4()
    {
        SceneManager.LoadScene("Cutscene4");
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
        SceneManager.LoadScene("Cutscene5");
    }
    public void Maze8()
    {
        SceneManager.LoadScene("Cutscene6");
    }
    public void Maze9()
    {
        SceneManager.LoadScene("Cutscene7");
    }
    public void Maze10()
    {
        SceneManager.LoadScene("Cutscene8");
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
    public void Maze6Blue()
    {
        SceneManager.LoadScene("Maze6Blue");
    }
    public void Maze7Blue()
    {
        SceneManager.LoadScene("Maze7Blue");
    }
    public void Maze8Blue()
    {
        SceneManager.LoadScene("Maze8Blue");
    }
    public void Maze9Blue()
    {
        SceneManager.LoadScene("Maze9Blue");
    }
    public void Maze10Blue()
    {
        SceneManager.LoadScene("Maze10Blue");
    }
}
