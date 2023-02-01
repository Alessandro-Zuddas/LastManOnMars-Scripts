using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager1 : MonoBehaviour
{
    public GameObject enemies1;
    public GameObject enemies2;
    public GameObject bossLifeSlider;

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;

    public GameObject levelExit;
    public GameObject boss;

   

    // Start is called before the first frame update
    void Start()
    {
        enemies1.SetActive(false);
        enemies2.SetActive(false);
        bossLifeSlider.SetActive(false);

        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(BoosHealthController.instance.bossHealt > 0)
        {
            levelExit.SetActive(false);
        }
        
        if(BoosHealthController.instance.bossHealt <= 0)
        {
            levelExit.SetActive(true);
            bossLifeSlider.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Lights")
        {
            light1.SetActive(true);
        }

        if(other.gameObject.tag == "Enemies1")
        {
            enemies1.SetActive(true);
            light1.SetActive(false);
            light2.SetActive(true);
        }

        if(other.gameObject.tag == "Enemies2")
        {
            enemies2.SetActive(true);
            bossLifeSlider.SetActive(true);
            light2.SetActive(false);
            light3.SetActive(true);
            AudioManager.instance.PlaySoundEffects(11);
        }
    }
}
