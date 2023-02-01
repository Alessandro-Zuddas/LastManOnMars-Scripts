using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Manager : MonoBehaviour
{
    public GameObject levelExit;
    public GameObject bossLifeSlider;

    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (BoosHealthController.instance.bossHealt > 0)
        {
            levelExit.SetActive(false);
        }

        if (BoosHealthController.instance.bossHealt <= 0)
        {
            levelExit.SetActive(true);
            bossLifeSlider.SetActive(false);
        }
    }
}
