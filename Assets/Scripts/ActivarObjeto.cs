using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivarObjeto : MonoBehaviour
{
    public GameObject objetoAActivarDesactivar;

    void Start()
    {
        // Asegúrate de que el objeto a activar/desactivar no sea nulo al inicio
        if (objetoAActivarDesactivar == null)
        {
            Debug.LogError("El objeto a activar/desactivar no está asignado.");
        }

        // Asigna la función OnButtonClick al evento de clic del botón
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
        // Activar o desactivar el objeto asociado
        objetoAActivarDesactivar.SetActive(!objetoAActivarDesactivar.activeSelf);
    }
}
