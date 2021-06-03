using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class NPCAnimation : MonoBehaviour
{    
    public Animator animator;
    

    // Start is called before the first frame update
    // Update is called once per frame
    void Start() {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
         animator.SetInteger("condition",0);

    }



}
