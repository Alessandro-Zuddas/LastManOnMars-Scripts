using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    

    public static GameManager gameManagerScript;

    public float waitAfterDying = 2f;   

    public GameObject loadingScreen, loadingImage;

    public Text loadingText;

    private void Awake()
    {
        gameManagerScript = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PlayAdventure()
    {
        //StartCoroutine(LoadLevelSelection());
        

        SceneManager.LoadScene("LevelSelection");
    }

    public void PlayerDied()
    {
        StartCoroutine(PlayerDiedCoroutine());
    }

    public IEnumerator PlayerDiedCoroutine()
    {
        yield return new WaitForSeconds(waitAfterDying);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseUnPause()
    {
        if (UIController.UIControllerScript.pausePanel.activeInHierarchy)
        {
            

            UIController.UIControllerScript.pausePanel.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;

            Time.timeScale = 1f;

            PlayerController.playerController.footStep.Play();
        }
        else
        {
           

            UIController.UIControllerScript.pausePanel.SetActive(true);

            Cursor.lockState = CursorLockMode.None;

            Time.timeScale = 0f;

            AudioManager.instance.StopMusic();
            PlayerController.playerController.footStep.Stop();
        }
    }

    public void MainMenu()
    {
        //SceneManager.LoadScene("MainMenu");
        

        StartCoroutine(LoadMainMenu());
    }

    public IEnumerator LoadMainMenu()           //Loading Screen menu
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

            yield return null;
        }
    }


    public IEnumerator LoadLevelSelection()           //Loading Screen Levels
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

            yield return null;
        }
    }

    IEnumerator OnlineDieCor()
    {
        yield return null;   //DA FARE!!!
    }
}
