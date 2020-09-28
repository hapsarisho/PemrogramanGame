using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int c = Jumlah(60, 40);
        Debug.Log("Hasil jumlah a + b adalah " + c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Merupakan fungsi penjumlahan dari 2 input angka
    /// </summary>
    /// <param name="a">Masukkan angka integer</param>
    /// <param name="b">Masukkan angka integer</param>
    /// <returns></returns>
    int Jumlah(int a, int b)
    {
        return a + b;
    }
}
