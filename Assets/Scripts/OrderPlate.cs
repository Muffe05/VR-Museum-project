using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderPlate : MonoBehaviour
{
    public GameObject objectPlaced;

    private void OnTriggerEnter(Collider other)
    {
        objectPlaced = other.gameObject;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Artefact"))
        {
            objectPlaced = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == objectPlaced)
        objectPlaced = null;
    }
}
