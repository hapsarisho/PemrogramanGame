﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan6 : MonoBehaviour
{
    public int[] intArray;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Menampilkan seluruh array.");
        foreach (int a in intArray)
        {
            Debug.Log(a);
        }
        Debug.Log("Nilai index ke 2 adalah " + intArray[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
