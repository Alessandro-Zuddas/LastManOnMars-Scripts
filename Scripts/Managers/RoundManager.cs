using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    public GameObject enemies1;
    public GameObject enemies2;
    public GameObject enemies3;
    public GameObject enemies4;

    public GameObject essentials1;
    public GameObject essentials2;
    public GameObject essentials3;
    public GameObject essentials4;

    public float roundLifetime;
    public float roundLifetime2;
    public float roundLifetime3;

    public int timerTrigger = 0;

    public Text timeText;
    public Text roundText;

    public AudioClip changeRoundAudio;

    // Start is called before the first frame update
    void Start()
    {
        enemies1.SetActive(false);
        enemies2.SetActive(false);
        enemies3.SetActive(false);
        enemies4.SetActive(false);

        essentials1.SetActive(false);
        essentials2.SetActive(false);
        essentials3.SetActive(false);
        essentials4.SetActive(false);

        StartCoroutine(RoundManagerCo());
    }

    // Update is called once per frame
    void Update()
    {
        if (timerTrigger == 1)
        {
            RoundOne();
        }

        if (timerTrigger == 2)
        {
            RoundTwo();
        }

        if (timerTrigger == 3)
        {
            RoundThree();
        }

        if(timerTrigger == 4)
        {
            LevelExit();
        }
    }

    IEnumerator RoundManagerCo()
    {
        timerTrigger = 1;

        GetComponent<AudioSource>().PlayOneShot(changeRoundAudio, 1f);

        enemies1.SetActive(true);
        essentials1.SetActive(true);

        yield return new WaitForSeconds(roundLifetime);

        enemies1.SetActive(false);
        essentials1.SetActive(false);

        timerTrigger = 2;

        GetComponent<AudioSource>().PlayOneShot(changeRoundAudio, 1f);

        enemies2.SetActive(true);
        essentials2.SetActive(true);

        yield return new WaitForSeconds(roundLifetime2);

        enemies2.SetActive(false);
        essentials2.SetActive(false);

        timerTrigger = 3;

        GetComponent<AudioSource>().PlayOneShot(changeRoundAudio, 1f);

        enemies3.SetActive(true);
        essentials3.SetActive(true);

        yield return new WaitForSeconds(roundLifetime3);

        enemies3.SetActive(false);
        essentials3.SetActive(false);

        timerTrigger = 4;

        GetComponent<AudioSource>().PlayOneShot(changeRoundAudio, 1f);

        enemies4.SetActive(true);
        essentials4.SetActive(true);
    }

    public void RoundOne()
    {    
        timeText.text = (int)roundLifetime + " Sec";

        roundText.text = " Round 1";

        roundLifetime -= Time.deltaTime;
    }

    public void RoundTwo()
    {
        timeText.text = (int)roundLifetime2 + " Sec";

        roundText.text = " Round 2";

        roundLifetime2 -= Time.deltaTime;
    }

    public void RoundThree()
    {
        timeText.text = (int)roundLifetime3 + " Sec";

        roundText.text = " Round 3";

        roundLifetime3 -= Time.deltaTime;
    }

    public void LevelExit()
    {
        roundText.enabled = false;

        timeText.text = "Find the exit!";
    }
}
