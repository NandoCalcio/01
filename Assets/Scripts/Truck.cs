using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Truck : Vehicle // INHERITANCE
{
    [SerializeField] TextMeshProUGUI truckSpeedDisplay;
    private float currentTruckSpeed;
    private Rigidbody truckRb;

    // Start is called before the first frame update
    void Start()
    {
        this.maxSpeed = 50f; 
        this.horsePower = 400f;
        this.accel = 1.0f;

        truckRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTruckSpeed < maxSpeed)
        {
            truckRb.AddForce(Vector3.right * this.horsePower * this.accel * Time.deltaTime);
            truckSpeedDisplay.text = "Bike Speed : " + TruckSpeed + " mph";
        }
                   
    }

    private float TruckSpeed
    {
        get
        {
            currentTruckSpeed = Mathf.Round(truckRb.velocity.magnitude * 3.6f);
            return currentTruckSpeed;
        }
    }

    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        Destroy(other.gameObject);
    }
}
