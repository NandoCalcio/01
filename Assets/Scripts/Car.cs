using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Car : Vehicle
{
    [SerializeField] TextMeshProUGUI carSpeedDisplay;
    private float currentCarSpeed;
    private Rigidbody carRb;

    // Start is called before the first frame update
    void Start()
    {
        this.maxSpeed = 75f;
        this.horsePower = 300f;
        this.accel = 1.5f;

        carRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCarSpeed < maxSpeed)
        {
            carRb.AddForce(Vector3.right * this.horsePower * this.accel * Time.deltaTime);
            carSpeedDisplay.text = "Bike Speed : " + CarSpeed + " mph";
        }
    }

    private float CarSpeed
    {
        get
        {
            currentCarSpeed = Mathf.Round(carRb.velocity.magnitude * 3.6f);
            return currentCarSpeed;
        }
    }
}
