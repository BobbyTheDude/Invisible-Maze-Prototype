using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float StartTime;
    public float TimeRemaining;
    public TextMeshProUGUI TimerText;
    public GameObject BlackScreen;
    public AudioClip Death;
    public GameObject LevelChanger;
    public bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = StartTime;
        TimerText.text = "Time Remaining: " + TimeRemaining.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        TimeRemaining -= Time.deltaTime;
        TimerText.text = "Time Remaining: " + Mathf.Round(TimeRemaining).ToString();
        if (TimeRemaining < 0f)
        {
            Debug.Log("We ded");
            BlackScreen.SetActive(true);
            AudioSource.PlayClipAtPoint(Death, transform.position);
            Destroy(this.gameObject);
            LevelChanger.GetComponent<LevelChanger>().FadeToLevel("GameOver");
        }
    }

}
