using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnTrigger : MonoBehaviour
{
    public string SceneToLoad;
    public bool BlueMode = false;
    public GameObject BlueController;
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
            if (BlueMode)
            {
                if (BlueController.GetComponent<BlueModeControl>().RemainingPads == 0)
                {
                    LevelChanger.GetComponent<LevelChanger>().FadeToLevel(SceneToLoad);
                }
            }
            else
            {
                LevelChanger.GetComponent<LevelChanger>().FadeToLevel(SceneToLoad);
            }
        }
    }
}
