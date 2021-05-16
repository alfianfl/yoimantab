using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{
//    public GameObject Panel;
   int counter;
   [SerializeField] private Canvas customCanvas;
//    public void OnTriggerEnter(Collider other) {
//        Panel.gameObject.SetActive(true);
//         counter++;
//        if(counter % 2==1){
//             Panel.gameObject.SetActive(false);
//        } else{
//            Panel.gameObject.SetActive(true);
//        }
    public void OnTriggerEnter(Collider other) {
       if(other.CompareTag("Player")){
           Cursor.lockState = CursorLockMode.None;
           Cursor.visible = true;
           customCanvas.enabled = true;
       }
    }
    public void Finish() {
        Debug.Log("hai2");
           customCanvas.enabled = false;
           Cursor.lockState = CursorLockMode.Locked;
           Cursor.visible = false;
    }
//    public void showhidePanel(){
//        counter++;
//        if(counter % 2==1){
//             Panel.gameObject.SetActive(false);
//        } else{
//            Panel.gameObject.SetActive(true);
//        }
//    }
}
