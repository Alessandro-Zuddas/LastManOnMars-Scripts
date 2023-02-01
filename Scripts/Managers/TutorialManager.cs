using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    private int tutorialCounter = 0;
    private string tutorialDone = "a";
    private string tutorialDone2 = "a";
    private string tutorialDone3 = "a";
    private string tutorialDone4 = "a";
    public string tutorialDone5 = "a";

    public Button backButton1;
    public Button backButton2;
    public Button backButton3;
    public Button backButton4;
    public Button backButton5;
    public Button backButton6;
    public Button pauseButton;

    public GameObject tutorialPanel1, tutorialPanel2, tutorialPanel3, tutorialPanel4, tutorialPanel5, tutorialPanel6;

    public static TutorialManager instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("TutorialDone", tutorialDone);
        PlayerPrefs.SetString("TutorialDone2", tutorialDone2);
        PlayerPrefs.SetString("TutorialDone3", tutorialDone3);
        PlayerPrefs.SetString("TutorialDone4", tutorialDone4);
        PlayerPrefs.SetString("TutorialDone5", tutorialDone5);

        if(tutorialCounter == 0)
        {
            StartCoroutine(TutorialStartCoroutine());
        }
        else
        {
            StartCoroutine(TutorialDestroyer());
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Tutorial2")
        {
            StartCoroutine(Tutorial2StartCoroutine());
        }

        if (other.gameObject.tag == "Tutorial3")
        {
            StartCoroutine(Tutorial3StartCoroutine());
        }

        if (other.gameObject.tag == "Tutorial4")
        {
            StartCoroutine(Tutorial4StartCoroutine());
        }

        if (other.gameObject.tag == "Tutorial5")
        {
            StartCoroutine(Tutorial5StartCoroutine());
        }

        if (other.gameObject.tag == "Tutorial6")
        {
            StartCoroutine(Tutorial6StartCoroutine());
        }
    }

    IEnumerator TutorialStartCoroutine()
    {
        yield return new WaitForSeconds(1f);

        pauseButton.interactable = false;

        tutorialPanel1.SetActive(true);

        backButton1.interactable = false;

        yield return new WaitForSeconds(1f);

        Time.timeScale = 0f;

        tutorialCounter = 1;

        backButton1.interactable = true;

        pauseButton.interactable = true;
    }

    IEnumerator TutorialDestroyer()
    {
        yield return null;
    }

    IEnumerator Tutorial2StartCoroutine()
    {
        if(PlayerPrefs.GetString("TutorialDone") == tutorialDone)
        {
            tutorialPanel2.SetActive(true);

            pauseButton.interactable = false;

            backButton2.interactable = false;

            yield return new WaitForSeconds(1f);

            Time.timeScale = 0f;

            PlayerPrefs.SetString("TutorialDone", "b");

            backButton2.interactable = true;

            pauseButton.interactable = true;
        }
    }


    IEnumerator Tutorial3StartCoroutine()
    {
        if (PlayerPrefs.GetString("TutorialDone2") == tutorialDone)
        {
            tutorialPanel3.SetActive(true);

            pauseButton.interactable = false;

            backButton3.interactable = false;

            yield return new WaitForSeconds(1f);

            Time.timeScale = 0f;

            PlayerPrefs.SetString("TutorialDone2", "b");

            backButton3.interactable = true;

            pauseButton.interactable = true;
        }
    }

    IEnumerator Tutorial4StartCoroutine()
    {
        if (PlayerPrefs.GetString("TutorialDone3") == tutorialDone)
        {
            tutorialPanel4.SetActive(true);

            pauseButton.interactable = false;

            backButton4.interactable = false;

            yield return new WaitForSeconds(1f);

            Time.timeScale = 0f;

            PlayerPrefs.SetString("TutorialDone3", "b");

            backButton4.interactable = true;

            pauseButton.interactable = true;
        }
    }

    IEnumerator Tutorial5StartCoroutine()
    {
        if (PlayerPrefs.GetString("TutorialDone4") == tutorialDone)
        {
            tutorialPanel5.SetActive(true);

            pauseButton.interactable = false;

            backButton5.interactable = false;

            yield return new WaitForSeconds(1f);

            Time.timeScale = 0f;

            PlayerPrefs.SetString("TutorialDone4", "b");

            backButton5.interactable = true;

            pauseButton.interactable = true;
        }
    }


    IEnumerator Tutorial6StartCoroutine()
    {
        if (PlayerPrefs.GetString("TutorialDone5") == tutorialDone)
        {
            tutorialPanel6.SetActive(true);

            pauseButton.interactable = false;

            backButton6.interactable = false;

            yield return new WaitForSeconds(1f);

            Time.timeScale = 0f;

            PlayerPrefs.SetString("TutorialDone5", "b");

            backButton6.interactable = true;

            pauseButton.interactable = true;
        }
    }

    public void CloseTutorial1()
    {
        AudioManager.instance.PlaySoundEffects(10);
        tutorialPanel1.SetActive(false);
        Time.timeScale = 1f;
    }

    public void CloseTutorial2()
    {
        AudioManager.instance.PlaySoundEffects(10);
        tutorialPanel2.SetActive(false);
        Time.timeScale = 1f;
    }

    public void CloseTutorial3()
    {
        AudioManager.instance.PlaySoundEffects(10);
        tutorialPanel3.SetActive(false);
        Time.timeScale = 1f;
    }

    public void CloseTutorial4()
    {
        AudioManager.instance.PlaySoundEffects(10);
        tutorialPanel4.SetActive(false);
        Time.timeScale = 1f;
    }

    public void CloseTutorial5()
    {
        AudioManager.instance.PlaySoundEffects(10);
        tutorialPanel5.SetActive(false);
        Time.timeScale = 1f;
    }

    public void CloseTutorial6()
    {
        AudioManager.instance.PlaySoundEffects(10);
        tutorialPanel6.SetActive(false);
        Time.timeScale = 1f;
    }
}
