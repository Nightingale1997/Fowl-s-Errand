using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //public GameObject chicken;
    public CharacterController controller;
    public float speed;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public Transform rotationCam; //to rotate the chicken with cam
    public Animator ChickenRun;



    // Start is called before the first frame update
    void Start()
    {
        ChickenRun = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        
        
        //Change where the chicken is looking at when moving 
        if (direction.magnitude >= 0.1f)
        {
            //changes direction by a fixed angle
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + rotationCam.eulerAngles.y;
            
            //smooth change of direction
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f,targetAngle,0f)*Vector3.forward;
            
            //Move Chicken
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            //Animate Chicken
            ChickenRun.Play("Run In Place");

            


            if (Input.GetKey(KeyCode.Space))
            {
                
                moveDir = moveDir + new Vector3(0, 2, 0).normalized;
                controller.Move(moveDir.normalized * speed * Time.deltaTime);
                

            }

        }
        




        // JUMP AND RESET
        /*
        if (Input.GetKey(KeyCode.Space))
        {
            //chicken.GetComponent<Rigidbody>().AddForce(0, 30, 0);
            //Vector3 chickenMovement = new Vector3(0, 3, 0) * speed * Time.deltaTime;
            chickenMovement = new Vector3(0, 2, 0).normalized * speed * Time.deltaTime;
            controller.Move(chickenMovement);
            //transform.Translate(chickenMovement, Space.Self);

        }
        */
        if (Input.GetKey(KeyCode.R))
        {
            // To reset position
            

        }

        //TO DO
        // fix Jumping
        
    }
}

