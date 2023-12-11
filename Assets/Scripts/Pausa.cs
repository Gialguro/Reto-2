using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public Canvas pausaCanvas;
    private bool juegoPausado = false;

    void Start()
    {
        pausaCanvas.enabled = false;
        SceneManager.sceneLoaded += OnSceneLoaded; 
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        juegoPausado = false; 
        Time.timeScale = 1f; 
        pausaCanvas.enabled = false;
        AudioListener.pause = false;
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
            Time.timeScale = 0f;
            pausaCanvas.enabled = true;
            AudioListener.pause = true;
        }
        else
        {
            Time.timeScale = 1f;
            pausaCanvas.enabled = false;
            AudioListener.pause = false;
        }
    }

   
    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
