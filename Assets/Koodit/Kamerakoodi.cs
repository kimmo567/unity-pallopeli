using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kamerakoodi: MonoBehaviour
{
    public Transform pelaaja;

    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(pelaaja);
    }
}