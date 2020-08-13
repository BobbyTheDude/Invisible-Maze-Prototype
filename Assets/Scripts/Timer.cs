using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float StartTime;
    public float TimeRemaining;
    public float BlinkTimer = 0f;
    public TextMeshProUGUI TimerText;
    public GameObject BlackScreen;
    public AudioClip Death;
    public GameObject LevelChanger;
    public GameObject Player;
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
            AudioSource.PlayClipAtPoint(Death, Player.transform.position);
            Destroy(this.gameObject);
            LevelChanger.GetComponent<LevelChanger>().FadeToLevel("GameOver");
        }
        if (TimeRemaining < 11f)
        {
            BlinkTimer = BlinkTimer + Time.deltaTime;
            if (BlinkTimer >= 0.5)
            {
                TimerText.color = new Color(255f, 0f, 0f);
            }
            if (BlinkTimer >= 1)
            {
                TimerText.color = new Color(255f, 255f, 255f);
                BlinkTimer = 0f;
            }
        }
    }

}
