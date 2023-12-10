using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraSwitcher : MonoBehaviour
{
    public GameObject[] cameras;
    private int currentCam;
    private int previousCam;

    void Start()
    {
        if (cameras.Length > 0)
        {
            currentCam = 0;
            previousCam = 0;
            ActivateCurrentCamera();
        }
       
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            ActivateCamera(2); 
        }
        else
        {
          
            if (Input.GetKeyDown(KeyCode.C))
            {
                SwitchBetweenCamera1And2();
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
              
                ActivatePreviousCamera();
            }
        }
    }

    void SwitchBetweenCamera1And2()
    {
        currentCam = (currentCam == 0) ? 1 : 0;

        ActivateCurrentCamera();
    }

    void ActivateCamera(int index)
    {
       
        if (index >= 0 && index < cameras.Length)
        {
            for (int i = 0; i < cameras.Length; i++)
            {
                cameras[i].SetActive(i == index);
            }
        }
        
    }

    void ActivateCurrentCamera()
    {       
        ActivateCamera(currentCam);
    }

    void ActivatePreviousCamera()
    {   
        previousCam = currentCam;
      
        ActivateCamera(previousCam);
    }
}

