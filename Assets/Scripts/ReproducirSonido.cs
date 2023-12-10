using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproducirSonido : MonoBehaviour
{
    public string tagObjetivo = "Barreras";  
    public AudioSource audioSource;         

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tagObjetivo))
        {
            
            if (audioSource != null)
            {
                audioSource.Play();
            }
            
        }
    }
}