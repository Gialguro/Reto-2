using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    public float rpm;
    public float currentSpeed; 
    public float maxSpeed = 100f;
    public float maxRpm = 9000f;

    void Update()
    {
        
        float speed = GetComponent<Rigidbody>().velocity.magnitude;
        currentSpeed = speed; 
        rpm = CalculateRPM(speed);
    }

    float CalculateRPM(float speed)
    {
        
        return (speed / maxSpeed) * maxRpm;
    }
}
