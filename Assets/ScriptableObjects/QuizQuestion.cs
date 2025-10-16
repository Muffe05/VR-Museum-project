using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Question", menuName = "Quiz/Question", order = 1)]
public class QuizQuestion : ScriptableObject
{
    public string quizText;
    public string[] questions;
    public int answerIndex;
}
