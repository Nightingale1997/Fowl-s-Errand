using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float carSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 void Update()
    {
        Vector3 carMovement = new Vector3(10, 0, 0) * carSpeed * Time.deltaTime;
        transform.Translate(carMovement, Space.Self);
    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("test");
        if (other.gameObject.tag == "Despawner")
        {
            Destroy(gameObject);
            //or gameObject.SetActive(false);
        }
    }
}
