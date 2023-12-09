using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToMainMenu : MonoBehaviour
{
    private bool isPaused;
    public GameObject backPanel;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("esc"))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                backPanel.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                backPanel.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
    public void Resume()
    {
        isPaused = !isPaused;
    }
}
