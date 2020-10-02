using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagesMove : MonoBehaviour
{
    int[] posX = new int[] { 0, -18, -36, -54 };
    int idx = 0;
    public AudioSource[] audio;
    void Start()
    {
        audio[idx].Play();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (idx < posX.Length - 1)
            {
                idx++;
                audio[idx].Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (idx > 0)
            {
                idx--;
                audio[idx].Play();
            }
        }
        transform.position = Vector3.MoveTowards(transform.position,
            new Vector3(posX[idx], transform.position.y), 50 * Time.deltaTime);
    }
}
