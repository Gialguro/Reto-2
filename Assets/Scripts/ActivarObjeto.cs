using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivarObjeto : MonoBehaviour
{
    public GameObject objetoAActivarDesactivar;

    void Start()
    {
        
        if (objetoAActivarDesactivar == null)
        {
            Debug.LogError("El objeto a activar/desactivar no está asignado.");
        }

       
        Button boton = GetComponent<Button>();
        if (boton != null)
        {
            boton.onClick.AddListener(OnButtonClick);
        }
        else
        {
            Debug.LogError("Este script debe estar adjunto a un objeto con un componente Button.");
        }
    }

    void OnButtonClick()
    {
        objetoAActivarDesactivar.SetActive(!objetoAActivarDesactivar.activeSelf);
    }
}
