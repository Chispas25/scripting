using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaEstado : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        miPanel= GameObject.Find("Panel");

        miPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivaPanel()
    {
        
        if(miPanel.activeSelf == true)
        {
            Debug.Log("Hola");

        }

    }

    private GameObject miPanel;
}
