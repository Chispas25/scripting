using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vidaF <= 0)
        {

            Destroy(this.gameObject);
        }
    }

    public int vidaF= 10;
}
