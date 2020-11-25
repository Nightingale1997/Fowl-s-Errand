﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //public GameObject chicken;
    public Rigidbody chickenBody;
    public float speed;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public Transform rotationCam; //to rotate the chicken with cam
    private Animator ChickenRun;
    bool isgrounded = true;



    // Start is called before the first frame update
    void Start()
    {
        ChickenRun = gameObject.GetComponent<Animator>();

        // get the distance to ground

    }

    
 

// Update is called once per frame
void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //float locationY = Input.GetAxisRaw(""); //Correct the Y position when walking
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (isgrounded == true)
        {
            //Change where the chicken is looking at when moving 
            if (direction.magnitude >= 0.1f)
            {
                //transform.position = controller.gameObject.GetComponent<Rigidbody>().position;
                //changes direction by a fixed angle
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + rotationCam.eulerAngles.y;

                //smooth change of direction
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

                //controller.SimpleMove(moveDir.normalized * speed*10 * Time.deltaTime);


                //Animate Chicken
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    speed = 5;
                    ChickenRun.SetBool("Run", true);
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    ChickenRun.SetBool("Run", false);
                    speed = 2;
                }
                else ChickenRun.SetBool("Walk", true);

                //else ChickenRun.SetBool("Walk", false);
                //ChickenRun.Play("Walk W Root");
                //Move Chicken

                chickenBody.velocity = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward * speed;


            }
            else
            {
                ChickenRun.SetBool("Walk", false);
                ChickenRun.SetBool("Run", false);
            }
        }
        else
        {
            ChickenRun.SetBool("Walk", false);
            ChickenRun.SetBool("Run", true);
        }

        /*
        if (Input.GetButtonDown("Jump"))
        {
            ChickenRun.SetBool("Run", true);
            Vector3 moveDir = new Vector3(0, 2, 0).normalized;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
            if (Input.GetButtonUp("Jump")) {
                ChickenRun.SetBool("Run", false);
            }
        }
        */



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
            chickenBody.gameObject.transform.position = new Vector3(0, 0, 0);

        }

        //TO DO
        // fix Jumping
        
    }

    //make sure u replace "floor" with your gameobject name.on which player is standing
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("Grounded");
            isgrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("Not grounded");
            isgrounded = false;
        }
    }


}

