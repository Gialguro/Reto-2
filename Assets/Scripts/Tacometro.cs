using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tacometro : MonoBehaviour
{
    public RectTransform rpmNeedle; 
    public RectTransform speedNeedle; 
    public Motor motor; 

    void Update()
    {
        if (motor != null)
        {
            
            float normalizedRPM = Mathf.Clamp01(motor.rpm / motor.maxRpm);
            float rpmRotation = Mathf.Lerp(140f, 0f, normalizedRPM);

            
            float normalizedSpeed = Mathf.Clamp01(motor.currentSpeed / motor.maxSpeed);
            float speedRotation = Mathf.Lerp(140, -60f, normalizedSpeed);

            
            rpmNeedle.rotation = Quaternion.Euler(0f, 0f, rpmRotation);
            speedNeedle.rotation = Quaternion.Euler(0f, 0f, speedRotation);
        }
        
    }
}
