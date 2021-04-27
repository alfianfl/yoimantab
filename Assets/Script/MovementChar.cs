using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovementChar : MonoBehaviour
{    
    [SerializeField] float speed = 5f ;
    public CharacterController controller;
    Vector3 moveDir = Vector3.zero;
    float rot = 0f;
    float rotSpeed= 80;
    public Animator animator;
    // Start is called before the first frame update
    // Update is called once per frame
    void Start() {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("condition",1);
            moveDir = new Vector3(0,0,1);
            moveDir *= speed;
            moveDir = transform.TransformDirection(moveDir);
        }
        if(Input.GetKeyUp(KeyCode.W)){
            animator.SetInteger("condition",0);
            moveDir = new Vector3(0,0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("condition",1);
            moveDir = new Vector3(0,0,1);
            moveDir *= speed;
            moveDir = transform.TransformDirection(moveDir);
        }
        if(Input.GetKeyUp(KeyCode.A)){
            animator.SetInteger("condition",0);
            moveDir = new Vector3(0,0,0);
        }
             
        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3 (0,rot,0);
        controller.Move(moveDir*Time.deltaTime);
    }
}
