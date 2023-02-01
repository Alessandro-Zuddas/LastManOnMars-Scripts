using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnlineTutorialManager : MonoBehaviour
{
    public GameObject tutorialPanel;

    public AudioClip sfxClick;

    // Start is called before the first frame update
    void Start()
    {
        SecureClose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SecureClose()
    {
        tutorialPanel.SetActive(false);
    }

    public void ClosePanels()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick);

        tutorialPanel.SetActive(false);
    }

    public void OpenTutorial()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick);

        tutorialPanel.SetActive(true);
    }
}
