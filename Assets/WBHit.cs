using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBHit : MonoBehaviour
{
    public Rigidbody chickenThrown;
    
    // Start is called before the first frame update
    void Start()
    {
        //chickenThrown = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            chickenThrown.velocity = new Vector3(5f, 5f, 5f);
            //chickenThrown.AddForce(5f, 5f, 5f);
            chickenThrown.constraints = RigidbodyConstraints.None; //let the chicken fall on its sides and face
            Debug.Log("HIT");
            
            //chickenThrown.constraints = RigidbodyConstraints.FreezeRotationX;
            //chickenThrown.constraints = RigidbodyConstraints.FreezeRotationZ;
        }
    }
}
