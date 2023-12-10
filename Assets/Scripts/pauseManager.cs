using System;
using UnityEngine;

public class pauseManager : MonoBehaviour
{
    public static bool pause = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pause)
        {
            modePause();
            Console.WriteLine("Pausa");
        }

        if (Input.GetKeyDown(KeyCode.Escape) && pause)
        {
            modePlay();
            Console.WriteLine("Continue");
        }
    }

    public void modePause()
    {
        pause = true;
        FindChild("Continue").SetActive(true);
        Time.timeScale = 0;
    }

    public void modePlay()
    {
        pause = false;
        FindChild("Continue").SetActive(false);
        Time.timeScale = 1;
    }

    private GameObject FindChild(string childName)
    {
        Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
        foreach (Transform child in children)
        {
            if (child.name == childName)
            {
                return child.gameObject;
            }
        }
        return null;
    }

    public void modePlay2()
    {
        pause = false;
        Time.timeScale = 1;
    }
}
