
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KahootPuzzle : MonoBehaviour
{
    public List<QuizQuestion> puzzleList = new List<QuizQuestion>();
    public GameObject[] answerButtons;
    public int currentQuestion = 0;
    public void InitializeQuestion()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<Text>().text = puzzleList[currentQuestion].questions[i];
            currentQuestion++;
        }
    }
    public void CheckAnswer(int index)
    {
        if (index == puzzleList[currentQuestion].answerIndex)
        {
            Debug.Log("Correct Answer");
            currentQuestion++;
            if (currentQuestion > puzzleList.Count)
            {
                PuzzleCompleted();
                return;
            }
            else InitializeQuestion();
        }
        else
        {
            Debug.Log("You Failed");
            currentQuestion = 0;
            InitializeQuestion();
        }
    }
    public void PuzzleCompleted()
    {
        Debug.Log("Puzzle is done");
    }
}
