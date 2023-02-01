using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager2 : MonoBehaviour
{
    public AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("ExposedMaster"))
        {
            mixer.SetFloat("ExposedMaster", PlayerPrefs.GetFloat("ExposedMaster"));
            
        }

        if (PlayerPrefs.HasKey("ExposedMusic"))
        {
            mixer.SetFloat("ExposedMusic", PlayerPrefs.GetFloat("ExposedMusic"));
           
        }

        if (PlayerPrefs.HasKey("ExposedSFX"))
        {
            mixer.SetFloat("ExposedSFX", PlayerPrefs.GetFloat("ExposedSFX"));
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
