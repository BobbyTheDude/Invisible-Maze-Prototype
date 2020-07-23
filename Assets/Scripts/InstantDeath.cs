using System.Collections;
using System.Collections.Generic;
using System.Media;
using UnityEngine;

public class InstantDeath : MonoBehaviour
{
    public string GameOver;

    public AudioClip Death;

    public GameObject BlackScreen;

    public GameObject LevelChanger;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BlackScreen.SetActive(true);
            AudioSource.PlayClipAtPoint(Death, transform.position);
            LevelChanger.GetComponent<LevelChanger>().FadeToLevel(GameOver);
        }
    }
}
