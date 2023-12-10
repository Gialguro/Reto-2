using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public Canvas pausaCanvas; // Asigna el Canvas desde el Editor de Unity
    private bool juegoPausado = false;

    void Start()
    {
        pausaCanvas.enabled = false; // Asegúrate de que el Canvas esté desactivado al inicio
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        juegoPausado = !juegoPausado;

        if (juegoPausado)
        {
            Time.timeScale = 0f; // Pausar el tiempo del juego
            pausaCanvas.enabled = true; // Activar el Canvas de pausa
            // Desactivar todos los sonidos en la escena
            AudioListener.pause = true;
        }
        else
        {
            Time.timeScale = 1f; // Reanudar el tiempo del juego
            pausaCanvas.enabled = false; // Desactivar el Canvas de pausa
            // Activar nuevamente los sonidos en la escena
            AudioListener.pause = false;
        }
    }
}