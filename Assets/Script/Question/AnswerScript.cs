using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public SceneSwitch scene;
    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct Answer");
            SceneManager.LoadScene(0);
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
                        SceneManager.LoadScene(0);
            quizManager.correct();
        }
    }
}
