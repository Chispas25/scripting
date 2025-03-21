using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primero : MonoBehaviour
{
    // Start is called before the first frame update

    int miEdad = 21;

    float miAltura = 4.1f;

    string miNombre = "Khar";

    bool estoyCalvo = false;


    void Start()
    {
       Debug.Log($"Hola mi nombre es {miNombre} y tengo {miEdad} años.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
