using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemFinish : MonoBehaviour
{
    public MovementChar playerHealth;
    public float scorefinal;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Player")
        {
            scorefinal = playerHealth.currentHealth * 100 + playerHealth.score * 50;
            Debug.Log(scorefinal);
            Debug.Log(playerHealth.score);
        }
    }
}
