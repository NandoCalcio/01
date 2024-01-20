using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : Vehicle
{
    // Start is called before the first frame update
    void Start()
    {
        this.speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
