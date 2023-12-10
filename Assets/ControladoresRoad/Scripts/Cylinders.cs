using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cylinders : MonoBehaviour
{
    public Checkpoints checkpoints;
    public int n;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player") && checkpoints.GetObjetive()==n){
            checkpoints.NewObjective();
        }
    }
}
