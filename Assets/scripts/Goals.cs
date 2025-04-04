using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player"){
            
            GameManager.score = GameManager.score + value;
            
            this.GetComponent<Animator>().SetBool("capturamon", true);
            
            Destroy(this.gameObject, 1.0f);
        }
    }

    public int value = 1; 
}
