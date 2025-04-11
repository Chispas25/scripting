using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        adManagerObj = GameObject.Find("AudioManagerObj");

        miAudioManager = adManagerObj.GetComponent<AudioManager>();
        
        panelSettings = GameObject.Find("Pan Set");

        panelSettings.SetActive(false);

        panelExit = GameObject.Find("Pan Exit");

        panelExit.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InicioStart()
    {
        //Debug.Log("Voy a la escena 1");
        SceneManager.LoadScene("Escena 1");
        


    }

    public void IrSettings ()
    {
        panelSettings.SetActive(true);

    }

    public void SalirSettings ()
    {
        panelSettings.SetActive(false);

    }

    public void Salir()
    {
        panelExit.SetActive(true);

    }

    public void Volver()
    {
        panelExit.SetActive(false);

    }

    public void SalirJuego()
    {
        Application.Quit();

    }
    
    public void SuenaBoton()
    {
        miAudioManager.m_audioSource.PlayOneShot(miAudioManager.sMoneda);

    }
    //variables
    GameObject panelSettings;
    GameObject panelExit;
    GameObject adManagerObj;
    AudioManager miAudioManager;



}
