using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Test2");
        if (other.gameObject.tag == "Water")
        {
            Debug.Log("Test3");
            transform.position = new Vector3(-5.31f, 0.5f, -39);
        }
    }
}
