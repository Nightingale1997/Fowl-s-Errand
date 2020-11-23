using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float Timer = 2;
    GameObject carClone;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            carClone = Instantiate(car, new Vector3(-52.37f, 1.69f, -19.27f), Quaternion.Euler(new Vector3(0, -50, 0))) as GameObject;
            Timer = 2f;
        }
    }
}
