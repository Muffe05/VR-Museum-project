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
    private void OnTriggerExit(Collider other)
    {
        objectPlaced = null;
    }
}
