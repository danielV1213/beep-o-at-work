using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswerM : MonoBehaviour
{
    public bool CorrectAnswer;
    public void CheckAnswer()
    {
        Debug.Log("MODEL:" + CorrectAnswer);
    }

}
