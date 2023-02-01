using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotBoss : MonoBehaviour
{
    public AudioClip youLose;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(youLose, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
