using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallVisibilityControl : MonoBehaviour
{
    public float VisibilityTime;
    public List<GameObject> Walls = new List<GameObject>();
    public AudioClip Pop;
    public GameObject Player;
    public List<GameObject> VisPads = new List<GameObject>();
    public Material RegularVisPad;
    public Material BlinkingVisPad;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject NewWall in GameObject.FindGameObjectsWithTag("Wall"))
        {
            Walls.Add(NewWall);
        }
        foreach(GameObject NewVisPad in GameObject.FindGameObjectsWithTag("VisPad"))
        {
            VisPads.Add(NewVisPad);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VisPadSteppedOn()
    {
        foreach (GameObject Wall in Walls)
        {
            MeshRenderer R = Wall.GetComponent<MeshRenderer>();
            R.enabled = true;
        }
        foreach (GameObject WallVisPad in VisPads)
        {
            WallVisPad.GetComponent<MeshRenderer>().material = BlinkingVisPad;
        }
        StartCoroutine(WallsVisible());
        AudioSource.PlayClipAtPoint(Pop, Player.transform.position);
    }
    IEnumerator WallsVisible()
    {
        yield return new WaitForSeconds(VisibilityTime);
        foreach (GameObject Wall in Walls)
        {
            MeshRenderer R = Wall.GetComponent<MeshRenderer>();
            R.enabled = false;
        }
        foreach (GameObject WallVisPad in VisPads)
        {
            
            WallVisPad.GetComponent<MeshRenderer>().material = RegularVisPad;
            WallVisPad.GetComponent<WallVisPad>().SteppedOn = false;
        }
        AudioSource.PlayClipAtPoint(Pop, Player.transform.position);
    }
}
