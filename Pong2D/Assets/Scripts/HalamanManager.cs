using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour
{
    public bool isEscapeToExit;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp (KeyCode.Escape))
        {
            Application.Quit();
        } else {
            KembaliKeMenu();
        }
    }

    public void MulaiPermainan()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void KembaliKeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
