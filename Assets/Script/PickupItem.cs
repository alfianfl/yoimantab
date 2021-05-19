using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public MovementChar playerHealth;
    public float durabilityBonus = 10f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);   
            playerHealth.currentHealth = playerHealth.currentHealth + durabilityBonus ;
        }
    }
}
