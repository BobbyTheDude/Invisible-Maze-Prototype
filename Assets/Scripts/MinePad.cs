using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinePad : MonoBehaviour
{
    public AudioClip Tick;
    public AudioClip Explode;
    public AudioClip Death;
    public bool PlayerInZone;
    public GameObject Player;
    public GameObject BlackScreen;
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
            AudioSource.PlayClipAtPoint(Tick,transform.position);
            PlayerInZone = true;
            StartCoroutine(BlowUp());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerInZone = false;
    }
    IEnumerator BlowUp()
    {
        yield return new WaitForSeconds(3f);
        AudioSource.PlayClipAtPoint(Explode, transform.position);
        if (PlayerInZone)
        {
            //StartCoroutine(Player.GetComponent<PlayerMove>().GameOver());
            AudioSource.PlayClipAtPoint(Death, transform.position);
            BlackScreen.SetActive(true);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
