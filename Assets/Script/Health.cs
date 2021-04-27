using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int maxHealth = 100;
    private int currentHealt;
    public event Action<float> OnHealthPctChange = delegate{ } ;

    private void OnEnable() {
        currentHealt = maxHealth;
    } 

    public void ModifyHealth(int amount) {
        currentHealt += amount ;
        float currentHealtPct = (float)currentHealt / (float)maxHealth;
        OnHealthPctChange(currentHealtPct);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) {
            ModifyHealth(-10);
        }
    }
}
