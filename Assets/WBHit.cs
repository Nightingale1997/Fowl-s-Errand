using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBHit : MonoBehaviour
{
    public Rigidbody chickenThrown;
    public GameObject rope;
    float speed = 2;
    private Vector3 initialVelocity;
    // Start is called before the first frame update
    void Start()
    {
        //chickenThrown = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //moving the WBall -- ROPE
        rope.transform.Rotate((Mathf.Cos(Time.time)), 0.0f, 0.0f, Space.Self);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Toon Chicken")
        {




            chickenThrown.velocity = new Vector3(speed * Mathf.Sin(rope.transform.rotation.x), chickenThrown.transform.rotation.y, chickenThrown.transform.position.z);
            Debug.Log(chickenThrown.velocity);
            Debug.Log(rope.transform.rotation.x);
            //chickenThrown.AddForce(5f, 5f, 5f);
            //chickenThrown.constraints = RigidbodyConstraints.None; //let the chicken fall on its sides and face

            //chickenThrown.velocity = new Vector3(5f, 5f, 5f);
            //chickenThrown.AddForce(5f, 5f, 5f);

            //chickenThrown.constraints = RigidbodyConstraints.FreezeRotationX;
            //chickenThrown.constraints = RigidbodyConstraints.FreezeRotationZ;
        }

    }
}
