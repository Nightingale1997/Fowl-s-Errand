using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //public GameObject chicken;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //chicken.GetComponent<Rigidbody>().AddForce(-10, 20, -10);
            Vector3 chickenMovement = new Vector3(0, 0, 1) * speed * Time.deltaTime;
            transform.Translate(chickenMovement, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 chickenMovement = new Vector3(0, 0, -1) * speed * Time.deltaTime;
            transform.Translate(chickenMovement, Space.Self);
            //chicken.GetComponent<Rigidbody>().AddForce(10, 20, 10);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 chickenMovement = new Vector3(-1, 0, 0) * speed * Time.deltaTime;
            transform.Translate(chickenMovement, Space.Self);
            //chicken.GetComponent<Rigidbody>().AddForce(-10, 20, 10);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //chicken.GetComponent<Rigidbody>().AddForce(10, 20, -10);
            Vector3 chickenMovement = new Vector3(1, 0, 0) * speed * Time.deltaTime;
            transform.Translate(chickenMovement, Space.Self);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //chicken.GetComponent<Rigidbody>().AddForce(0, 30, 0);
            Vector3 chickenMovement = new Vector3(0, 3, 0) * speed * Time.deltaTime;
            transform.Translate(chickenMovement, Space.Self);
        }

        if (Input.GetKey(KeyCode.R))
        {
//            Vector3 chickenStand = new Vector3(0, 230, 0);
            transform.localRotation.z.Equals(230);
            transform.Translate(0f,0.508f,0f, Space.Self);
        }

        //rotation Y: look side ways 

    }
}
