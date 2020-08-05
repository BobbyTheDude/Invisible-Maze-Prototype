using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public string Hint;
    public GameObject HintUI;
    public GameObject HintText;
    public GameObject Postprocessor;
    // Start is called before the first frame update
    void Start()
    {
        Resume();
        HintText.GetComponent<TextMeshProUGUI>().text = Hint;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Postprocessor.SetActive(false);
    }
   public void Pause()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Postprocessor.SetActive(true);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void HintButton()
    {
        PauseMenuUI.SetActive(false);
        HintUI.SetActive(true);
    }
    public void HintBack()
    {
        PauseMenuUI.SetActive(true);
        HintUI.SetActive(false);
    }

}
