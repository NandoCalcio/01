using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bike : Vehicle // INHERITANCE
{
    [SerializeField] TextMeshProUGUI bikeSpeedDisplay;
    private float currentBikeSpeed;
    private Rigidbody bikeRb;

    public AudioClip crashSound;

    private AudioSource bikeAudio;
    

    // Start is called before the first frame update
    void Start()
    {
        this.maxSpeed = 100f; 
        this.horsePower = 200f;
        this.accel = 2.0f;

        bikeRb = GetComponent<Rigidbody>();
        bikeAudio = GetComponent<AudioSource>();

        

    }

    // Update is called once per frame
    void Update()
    {
        Acceleration(); // ABSTRACTION
         
    }

    void Acceleration()
    {
        if (currentBikeSpeed < maxSpeed)
        {
            bikeRb.AddForce(Vector3.right * this.horsePower * this.accel * Time.deltaTime);
            bikeSpeedDisplay.text = "Bike Speed : " + BikeSpeed + " mph";
        }
    }

    private float BikeSpeed
    {
        get
        {
            currentBikeSpeed = Mathf.Round(bikeRb.velocity.magnitude * 3.6f); 
            return currentBikeSpeed;
        }
    }

    public override void OnTriggerEnter(Collider other) // POLYMORPHiSM
    {
        base.OnTriggerEnter(other);

        if (other.gameObject.CompareTag("Finish"))
        {
            bikeAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
    
        

    
}
