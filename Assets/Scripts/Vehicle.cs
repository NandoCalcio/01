using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected float maxSpeed; // ENCAPSULATION
    protected float horsePower;
    protected float accel;

    

    

    void Start()
    {
        
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
    }
}

