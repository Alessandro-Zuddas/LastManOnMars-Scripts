using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource mainMusic, victory;

    public AudioSource[] soundEffectsArray;

    public AudioClip[] allDeathsSounds;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StopMusic()
    {
        mainMusic.Stop();
    }

    public void PlayLevelVictory()
    {
        StopMusic();
        victory.Play();
    }

    public void PlaySoundEffects(int soundNumber)
    {
        soundEffectsArray[soundNumber].Stop();

        soundEffectsArray[soundNumber].Play();
    }

    public void StopSoundEffects(int soundNumber)
    {
        soundEffectsArray[soundNumber].Stop();
    }

    public void PlayDeath()
    {
        int rand = Random.Range(0, 4);

        if (rand == 0)
        {
            GetComponent<AudioSource>().PlayOneShot(allDeathsSounds[0]);
        }

        if (rand == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(allDeathsSounds[1]);
        }

        if (rand == 2)
        {
            GetComponent<AudioSource>().PlayOneShot(allDeathsSounds[2]);
        }

        if (rand == 3)
        {
            GetComponent<AudioSource>().PlayOneShot(allDeathsSounds[3]);
        }
    }
}
