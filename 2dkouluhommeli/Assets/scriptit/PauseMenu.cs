using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(false);
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        if (paused == true)
        {
            PausePanel.SetActive(false);
            paused = false;
            Time.timeScale = 1;
        }

 
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Pause"))
        {
            if (paused == false)
            {
                PausePanel.SetActive(true);
                paused = true;
                Time.timeScale = 0;
            }

           else
            {
                PausePanel.SetActive(false);
                paused = false;
                Time.timeScale = 1;
            }

        }



    }
}
