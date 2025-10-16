using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPuzzle : MonoBehaviour
{
    public GameObject door;
    public InputField inputField;
    public string correctText;
    public void CheckAnswer()
    {
        if(inputField.text == correctText)
        {
            PuzzleCompleted();
        }
    }
    public void PuzzleCompleted()
    {
        door.SetActive(false);
        Debug.Log("Text Puzzle Finish");
        //puzzle is done
    }
}
