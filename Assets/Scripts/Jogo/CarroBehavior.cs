using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroBehavior : MonoBehaviour
{
    public float speed;
    public GameObject carro;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

        if(transform.position.x < -16)
        {
            Destroy(gameObject);
        }
    }
}
