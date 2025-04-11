using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();

        m_audioSource.clip = OST;

        m_audioSource.Play();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioSource m_audioSource;

    public AudioClip OST;

    public AudioClip sMoneda;
}
