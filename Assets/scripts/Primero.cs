using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       //int mult = Mult(num1, num2);
       //"Debug.Log()" es igual a "Console.Writeline()" en Unity
       
       
       this.GetComponent<Transform>().position = posinicial;
       

    }

    // Update is called once per frame
    void Update()
    {
        float posAct = this.GetComponent<Transform>().position.x;

        this.GetComponent<Transform>().position = new Vector3(posAct-0.001f, 0, 0);
    }

    public Vector3 posinicial = new Vector3(-1,0,0);

}
