using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallVisibility : MonoBehaviour
{
    public List<GameObject> Walls = new List<GameObject>();
    public float VisibilityTime;
    public AudioClip Pop;

    void Start()
    {
        foreach (GameObject NewWall in GameObject.FindGameObjectsWithTag("Wall"))
        {
            Walls.Add(NewWall);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            foreach (GameObject Wall in Walls)
            {
                MeshRenderer R = Wall.GetComponent<MeshRenderer>();
                R.enabled = true;
            }
            StopCoroutine(WallsVisible());
            StartCoroutine(WallsVisible());
            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
    IEnumerator WallsVisible()
    {
        yield return new WaitForSeconds(VisibilityTime);
        foreach (GameObject Wall in Walls)
        {
            MeshRenderer R = Wall.GetComponent<MeshRenderer>();
            R.enabled = false;
        }
        AudioSource.PlayClipAtPoint(Pop, transform.position);
    }
}
