using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialControl : MonoBehaviour
{
    public GameObject TutorialText;
    public GameObject Player;
    public GameObject Darken;
    public bool IsStopped = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsStopped)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                TutorialText.SetActive(false);
                Darken.SetActive(false);
                Destroy(this.gameObject);
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
            Darken.SetActive(true);
            TutorialText.SetActive(true);
            IsStopped = true;
        }
    }
}
