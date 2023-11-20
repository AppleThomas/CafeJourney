using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource.loop = true;
    }

  
}
