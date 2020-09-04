using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipText : MonoBehaviour
{
    public GameObject SkipTextObject;
    void Start()
    {
        StartCoroutine(Appear());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Appear()
    {
        yield return new WaitForSeconds(3);
        SkipTextObject.SetActive(true);
        StartCoroutine(Dissapear());
    }
    IEnumerator Dissapear()
    {
        yield return new WaitForSeconds(5);
        SkipTextObject.SetActive(false);
    }
}
