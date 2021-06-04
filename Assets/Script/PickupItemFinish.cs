using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupItemFinish : MonoBehaviour
{
    public MovementChar playerHealth;
   [SerializeField] private Canvas customCanvas;
    public Text tx;
   
    public float scorefinal;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            customCanvas.enabled = true;
            scorefinal = playerHealth.currentHealth * 100 + playerHealth.score * 50;
            tx.text = scorefinal.ToString();
            Debug.Log(scorefinal);
            Debug.Log(playerHealth.score);
        }
    }
}
