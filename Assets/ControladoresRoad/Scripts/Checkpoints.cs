using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public GameObject[] checkPoint;
    public int Objective=0;

    int vueltas =-1;
    // Start is called before the first frame update
    void Start()
    {
        HideObjects();
        checkPoint[0].transform.LookAt(checkPoint[1].transform);
        ShowNextObject();
    }

    public int GetObjetive(){
        return Objective;
    }

    public void HideObjects()
    {
        foreach (GameObject obj in checkPoint)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.enabled = false; // Hacer invisible el objeto
            }

            // Hacer invisibles los hijos
            Renderer[] childRenderers = obj.GetComponentsInChildren<Renderer>(true);
            foreach (Renderer childRenderer in childRenderers)
            {
                childRenderer.enabled = false;
            }
        }
    }

    public void ShowNextObject()
    {
        if (Objective < checkPoint.Length)
        {
            GameObject objToShow = checkPoint[Objective];
            Renderer renderer = objToShow.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.enabled = true; // Hacer visible el objeto
            }

            // Hacer visibles los hijos
            Renderer[] childRenderers = objToShow.GetComponentsInChildren<Renderer>(true);
            foreach (Renderer childRenderer in childRenderers)
            {
                childRenderer.enabled = true;
            }

        }
    }

    public void HideLastObject()
        {
            if (Objective < checkPoint.Length)
            {
                GameObject objToShow = checkPoint[Objective];
                Renderer renderer = objToShow.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false; // Hacer visible el objeto
                }

                // Hacer visibles los hijos
                Renderer[] childRenderers = objToShow.GetComponentsInChildren<Renderer>(true);
                foreach (Renderer childRenderer in childRenderers)
                {
                    childRenderer.enabled = false;
                }

            }
        }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewObjective(){
        //checkPoint[Objective].SetActive(false);
        HideLastObject();
        Objective= (Objective + 1) % checkPoint.Length;
        ShowNextObject();

        //checkPoint[Objective].SetActive(true);
        checkPoint[Objective].transform.LookAt(checkPoint[(Objective+1) % checkPoint.Length].transform);
        if(Objective==1){
            vueltas++;
        }
        print(vueltas);
    }
}
