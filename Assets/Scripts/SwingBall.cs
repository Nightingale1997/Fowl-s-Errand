using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingBall : MonoBehaviour
{

    
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        //moving the WBall
        transform.Rotate((Mathf.Sin(Time.time))*2, 0.0f, 0.0f, Space.Self);
    }

    
}
