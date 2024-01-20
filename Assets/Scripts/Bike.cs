using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bike : Vehicle
{
    [SerializeField] TextMeshProUGUI bikeSpeedDisplay;
        
    // Start is called before the first frame update
    void Start()
    {
        this.speed = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        bikeSpeedDisplay.text = "Bike Speed : " + BikeSpeed + " mph";
    }

    private string BikeSpeed
    {
        get
        {
            string bikeSpeed = speed.ToString();
            return bikeSpeed;
        }
    }
}
