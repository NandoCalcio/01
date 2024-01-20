using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    // Start is called before the first frame update
    void Start()
    {
        this.speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
