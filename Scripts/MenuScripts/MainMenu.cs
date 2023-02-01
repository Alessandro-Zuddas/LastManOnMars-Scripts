using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject loadingScreen, loadingImage;

    public Text loadingText;

    public GameObject optionsScreen;

    public AudioClip sfxClick;

    public Button storyButton;
    public Button onlineButton;
    public Button thridButton;
    public Button settingsButton;
    public Button leaveButton;

    public int onlineInt;
    public int storyInt;

   

    public static MainMenu instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForButtons());

        Launcher.instance.isOnline = false;
        CheckForLevels.instance.isStoryMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void LoadMenu()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        StartCoroutine(LoadMainMenu());
    }

    public void LoadPlayGame()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);     

        StartCoroutine(LoadLvSelection());
    }


    public void PlayGame()
    {


        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        PlayerPrefs.SetInt("StoryMode", 1);
        storyInt = 1;

        SceneManager.LoadScene("LevelSelection");
        //StartCoroutine(PauseScreenScript.instance.LoadLevelSelection());

        //Pulire checkPoint con tasto next level

       // CheckpointController.checkpointScript.CheckPointReset();
    }

    public void OnlineMode()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        PlayerPrefs.SetInt("OnlineMode", 1);
        onlineInt = 1;

        StartCoroutine(LoadOnlineMode());
    }

    public void OpenShop()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        StartCoroutine(LoadMarsShop());
    }

    public void OpenOptions()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        optionsScreen.SetActive(true);
    }

    public void CloseOptions()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        optionsScreen.SetActive(false);
    }

    public void QuitGame()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        Application.Quit();
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

    public IEnumerator LoadLvSelection()           //Loading LevelSelection
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("LevelSelection");

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

    public IEnumerator LoadOnlineMode()           //Loading Online Mode
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Online1");

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

    public IEnumerator LoadMarsShop()           //Loading Mars Shop
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MarsShop");

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

    IEnumerator WaitForButtons()
    {
        storyButton.enabled = false;
        onlineButton.enabled = false;
        thridButton.enabled = false;
        settingsButton.enabled = false;
        leaveButton.enabled = false;

        yield return new WaitForSeconds(0.75f);

        storyButton.enabled = true;
        onlineButton.enabled = true;
        thridButton.enabled = true;
        settingsButton.enabled = true;
        leaveButton.enabled = true;
    }
}
