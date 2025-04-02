using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("Spawn");

        transform.position = spawn.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10)
        {
            transform.position = spawn.transform.position;

        }
    }

    public GameObject spawn;

    
}
