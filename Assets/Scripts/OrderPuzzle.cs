using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderPuzzle : MonoBehaviour
{
    public GameObject door;
    public GameObject[] plates;
    public GameObject[] objectOrder;
    public void CheckOrder()
    {
        List<GameObject> placedOrder = new List<GameObject>();
        placedOrder.Clear();
        for (int i = 0; i < plates.Length; i++)
        {
            placedOrder.Add(plates[i].GetComponent<OrderPlate>().objectPlaced);
        }
        for (int i = 0; i < plates.Length; i++)
        {
            if (placedOrder[i] != objectOrder[i])
                return;
        }
        PuzzleCompleted();
    }
    public void PuzzleCompleted()
    {
        door.SetActive(false);
        Debug.Log("Order Puzzle Complete");
        //puzzle is done
    }
}
