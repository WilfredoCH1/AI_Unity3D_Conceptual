using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pausa : MonoBehaviour
{
    public static bool MPausa = false;
    public GameObject PausaMenuCanvas;
 
    


    void Start()
    {
        Time.timeScale = 1f;
        
    }

    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (MPausa)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }

    }
    void Stop()
    {
        PausaMenuCanvas.SetActive(true);

        Time.timeScale = 0f;
        MPausa = true;
    }
    public void Play()
    {
        PausaMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        MPausa = false;

    }
    public void Salir()
    {
        Application.Quit();
    }
}
    
