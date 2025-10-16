using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform TeleportDestination;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject player = other.gameObject;
            if (player != null)
            {
                //player.enabled = false;
                other.transform.position = TeleportDestination.position;
                //player.enabled = true;
            }
        }
    }
}
