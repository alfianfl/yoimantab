using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class MovementChar : MonoBehaviour
{    
    [SerializeField] float speed = 1f ;
    public CharacterController controller;
    Vector3 moveDir = Vector3.zero;
    float rot = 0f;
    float rotSpeed= 100;
    public Animator animator;
    public float MaxHealth;
    public Slider _slide;
    public float currentHealth;
    

    // Start is called before the first frame update
    // Update is called once per frame
    void Start() {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        StartDurability();
    }
    
    void Update()
    {
        if(currentHealth > 0) {
            if (Input.GetKey(KeyCode.W) ||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D) )
            {
                animator.SetInteger("condition",1);
                animator.SetBool("defeat",false);
                float h = Input.GetAxisRaw("Horizontal");
                float v = Input.GetAxisRaw("Vertical");
                moveDir = new Vector3(h,0,v).normalized;
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
                rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime * 2;
                transform.eulerAngles = new Vector3 (0,rot,0);
                controller.Move(moveDir*Time.deltaTime);
                Durability();
            }
            if (Input.GetKey(KeyCode.S)) 
            {
                animator.SetInteger("condition",1);
                animator.SetBool("defeat",false);
                moveDir = new Vector3(0,0,1).normalized;
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
                rot += 3 * rotSpeed * Time.deltaTime;
                transform.eulerAngles = new Vector3 (0,rot,0);
                
                controller.Move(moveDir*Time.deltaTime);
                Durability();
            }
            if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) ||Input.GetKeyUp(KeyCode.S) ||Input.GetKeyUp(KeyCode.D) ){
                animator.SetInteger("condition",0);
                animator.SetBool("defeat",false);
                moveDir = new Vector3(0,0,0);
            }

        }
        else {
            animator.SetInteger("condition",0);
            animator.SetBool("defeat",true);

            moveDir = new Vector3(0,0,0);
        }
    }
    public void StartDurability() {
        currentHealth = MaxHealth;
        _slide.maxValue = MaxHealth;
        _slide.value = MaxHealth;
        
    }    
    public void Durability() {
        currentHealth = currentHealth - 0.01f;
        _slide.value = currentHealth;
        if(currentHealth == 0) {
            currentHealth = 0;
        }
    }


}
