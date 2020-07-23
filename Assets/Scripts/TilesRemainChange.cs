using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TilesRemainChange : MonoBehaviour
{
    //public Text TileText;
    public TextMeshProUGUI TileText;
    public GameObject BlueModeController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TileText.text = "Pads Remaining: " + BlueModeController.GetComponent<BlueModeControl>().RemainingPads.ToString();
    }
}
