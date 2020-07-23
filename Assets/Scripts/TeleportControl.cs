using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportControl : MonoBehaviour
{
    public Transform Teleport1;
    public Transform Teleport2;
    public GameObject Player;

    bool TeleportDisabled = false;

    public bool T1 = false;
    public bool T2 = false;

    void Update()
    {
        if (T1)
        {
            if (TeleportDisabled == false)
            {
                TeleportDisabled = true;
                Player.GetComponent<vThirdPersonInput>().enabled = false;
                Player.transform.position = Teleport2.transform.position;
                StartCoroutine(EnableTeleport());
                StartCoroutine(EnableMovement());
                T1 = false;
            }
            else
            {
                T1 = false;
            }

        }
        if (T2)
        {
            if (TeleportDisabled == false)
            {
                TeleportDisabled = true;
                Player.GetComponent<vThirdPersonInput>().enabled = false;
                Player.transform.position = Teleport1.transform.position;
                StartCoroutine(EnableTeleport());
                StartCoroutine(EnableMovement());
                T2 = false;
            }
            else
            {
                T2 = false;
            }
        }
    }

    IEnumerator EnableTeleport()
    {
        yield return new WaitForSeconds(2.5f);
        TeleportDisabled = false;
    }
    IEnumerator EnableMovement()
    {
        yield return new WaitForSeconds(.25f);
        Player.GetComponent<vThirdPersonInput>().enabled = true;
    }
}
