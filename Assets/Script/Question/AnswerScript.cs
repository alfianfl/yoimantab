using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnswerScript : MonoBehaviour
{
    public bool isCorrect ;
    // public QuizManager quizManager;
    // public SceneSwitch scene;
    public PanelScript panel;
    public void Answer()
    {
        Debug.Log(isCorrect);
        if(isCorrect == true)
        {
            Debug.Log("Correct Answer");
            panel.Finish(1);
            // quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            panel.Finish(0);
            // quizManager.correct();
        }
    }
}
