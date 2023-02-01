using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject loadingScreen, loadingImage;

    public Text loadingText;

    public AudioClip sfxClick;

    public Button characterButton;
    public Button skinsButton;
    public Button dlcButton;

    public GameObject characterPanel;
    public GameObject skinsPanel;
    public GameObject dlcPanel;

    public Button toggleLeftChar;
    public Button toggleRightChar;

    public Button toggleLeftSkins;
    public Button toggleRightSkins;

    public Button toggleLeftDlc;
    public Button toggleRightDlc;

    public GameObject[] allCharacters;
    public int currentCharIndex;

    public Material[] allSkins;
    public int currentSkinIndex;


    // Start is called before the first frame update
    void Start()
    {
        CloseUI();

        characterPanel.SetActive(true);
        characterButton.interactable = false;
        skinsButton.interactable = true;
        dlcButton.interactable = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        DialogueManager.instance.EndFunction();

        StartCoroutine(LoadMainMenu());
    }

    private void CloseUI()
    {
        characterPanel.SetActive(false);
        skinsPanel.SetActive(false);
        dlcPanel.SetActive(false);
    }

    public void CharacterButton()
    {
        CloseUI();

        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        characterPanel.SetActive(true);
        characterButton.interactable = false;
        skinsButton.interactable = true;
        dlcButton.interactable = true;
    }

    public void ToggleLeftChar()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        //Da Fare!!!
    }

    public void ToggleRightChar()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        //Da Fare!!!
    }

    public void SkinsButton()
    {
        CloseUI();

        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        skinsPanel.SetActive(true);
        skinsButton.interactable = false;
        characterButton.interactable = true;
        dlcButton.interactable = true;
    }

    public void ToggleLeftSkins()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        //Da Fare!!!
    }

    public void ToggleRightSkins()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        //Da Fare!!!
    }

    public void DlcButton()
    {
        CloseUI();

        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        dlcPanel.SetActive(true);
        dlcButton.interactable = false;
        characterButton.interactable = true;
        skinsButton.interactable = true;
    }

    public void ToggleLeftDlc()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        //Da Fare!!!
    }

    public void ToggleRightDlc()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        //Da Fare!!!
    }



    public IEnumerator LoadMainMenu()           //Loading Menu
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MainMenu");

        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            if (asyncLoad.progress >= .9f)
            {
                loadingText.text = "Touch the screen!";
                loadingImage.SetActive(false);

                if (Input.anyKeyDown)
                {
                    asyncLoad.allowSceneActivation = true;

                    Time.timeScale = 1f;
                }
            }

            PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "_cp", "");

            yield return null;
        }
    }
}
