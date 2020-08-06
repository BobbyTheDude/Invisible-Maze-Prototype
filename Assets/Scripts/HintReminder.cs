using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintReminder : MonoBehaviour
{
    public GameObject HintText;
    public GameObject PauseCanvas;
    void Start()
    {
        StartCoroutine(StartShowing());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            PauseCanvas.GetComponent<PauseMenu>().HintButton();
            HintText.SetActive(false);
        }
    }
    IEnumerator StartShowing()
    {
        yield return new WaitForSeconds(30);
        HintText.SetActive(true);
        StartCoroutine(StopShowing());
    }
    IEnumerator StopShowing()
    {
        yield return new WaitForSeconds(10);
        HintText.SetActive(false);
    }
}
