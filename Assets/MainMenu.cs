using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayGame2 ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void QuitGame(){
        Application.Quit();
    }
    public void  PlaySound()
 {
         Button b = GetComponent<Button>();
         AudioSource audio = GetComponent<AudioSource>();
         b.onClick.AddListener(delegate() { audio.Play(); });
 }
}
