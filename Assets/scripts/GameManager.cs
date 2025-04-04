using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Tienes {vidas} vidas");

        Debug.Log("Monedas : " + score);
    }

    public int vidas = 3;

    public static int score = 0;

    /*void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log($"Tienes {vidas} vidas");

        if(col.gameObject.name.StartsWith("Triangle"))
        {
            transform.position =
            
        }
    }*/
}
