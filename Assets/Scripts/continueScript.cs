using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueScript : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Maze1");
    }
    public void ContinueBlue()
    {
        SceneManager.LoadScene("BlueModeMenu");
    }
}
