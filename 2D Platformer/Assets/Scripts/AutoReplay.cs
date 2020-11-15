using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AutoReplay : MonoBehaviour
{
    public Text info;

    float timer = 0;

    void Start()
    {
        if (EnemyController.EnemyKilled == 3)
        {
            info.text = "Congratulation \n You Win!";
        }
    }

    void Update()
    {
        if (timer > 5)
        {
            Data.score = 0;
            EnemyController.EnemyKilled = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }
}
