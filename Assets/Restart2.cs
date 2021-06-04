using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart2 : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
    public void BackToMenuGame()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void NextStage()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
