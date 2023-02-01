using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostProManager : MonoBehaviour
{
    public GameObject postProVolume;

    private void Awake()
    {
        postProVolume.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
       if(postProVolume.activeInHierarchy)
        {
            postProVolume.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
