using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadfinal = velocidadbala * Time.deltaTime;
        
        transform.Translate(velocidadfinal, 0, 0);

        
    }

    public float velocidadbala = 1;

    public int potarma = 1;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.StartsWith("enemigo_fantasma"))
        {
            Destroy(this.gameObject);

            col.gameObject.GetComponent<FantasmaScript>().vidaF -= potarma;



        }
    }





}
    

    

