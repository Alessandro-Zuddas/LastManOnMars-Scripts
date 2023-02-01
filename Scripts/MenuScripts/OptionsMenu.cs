using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer mixer;

    public Slider masterSlider, musicSlider, sfxSlider;

    public Text masterText, musicText, sfxText;

    public AudioSource sfxClick;
    public AudioClip sfxClick2;

    public GameObject lqPanel;
    public GameObject hqPanel;

    public Button lowButton;
    public Button highButton;



    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("ExposedMaster"))
        {
            mixer.SetFloat("ExposedMaster", PlayerPrefs.GetFloat("ExposedMaster"));
            masterSlider.value = PlayerPrefs.GetFloat("ExposedMaster");
        }

        if (PlayerPrefs.HasKey("ExposedMusic"))
        {
            mixer.SetFloat("ExposedMusic", PlayerPrefs.GetFloat("ExposedMusic"));
            musicSlider.value = PlayerPrefs.GetFloat("ExposedMusic");
        }

        if (PlayerPrefs.HasKey("ExposedSFX"))
        {
            mixer.SetFloat("ExposedSFX", PlayerPrefs.GetFloat("ExposedSFX"));
            sfxSlider.value = PlayerPrefs.GetFloat("ExposedSFX");
        }

        if(PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            //lqPanel.SetActive(false);
            //hqPanel.SetActive(true);

            lowButton.interactable = false;
            highButton.interactable = true;
        }

        if(PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            //hqPanel.SetActive(false);
            //lqPanel.SetActive(true);

            highButton.interactable = false;
            lowButton.interactable = true;
        }

}

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetMasterVolume()
    {
        masterText.text = (masterSlider.value + 80).ToString();

        mixer.SetFloat("ExposedMaster", masterSlider.value);

        PlayerPrefs.SetFloat("ExposedMaster", masterSlider.value);
    }

    public void SetMusicVolume()
    {
        musicText.text = (musicSlider.value + 80).ToString();

        mixer.SetFloat("ExposedMusic", musicSlider.value);

        PlayerPrefs.SetFloat("ExposedMusic", masterSlider.value);
    }

    public void SetSfxVolume()
    {
        sfxText.text = (sfxSlider.value + 80).ToString();

        mixer.SetFloat("ExposedSFX", sfxSlider.value);

        PlayerPrefs.SetFloat("ExposedSFX", masterSlider.value);
    }

    public void PlaySFX()
    {
        sfxClick.Play();
    }

    public void StopSFX()
    {
        sfxClick.Stop();
    }

    public void SetQualityHigh()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick2, 1f);

        QualitySettings.SetQualityLevel(1);

        PlayerPrefs.SetInt("QualityLevel", 1);

        //hqPanel.SetActive(false);
        //lqPanel.SetActive(true);

        highButton.interactable = false;
        lowButton.interactable = true;
    }

    public void SetQualityLow()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick2, 1f);

        QualitySettings.SetQualityLevel(0);

        PlayerPrefs.SetInt("QualityLevel", 0);

        //lqPanel.SetActive(false);
        //hqPanel.SetActive(true);

        lowButton.interactable = false;
        highButton.interactable = true;
    }
    
    
}
