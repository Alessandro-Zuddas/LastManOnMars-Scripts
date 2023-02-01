using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScreenScript : MonoBehaviour
{
    public GameObject loadingScreen, loadingImage;

    public Text loadingText;

    public static PauseScreenScript instance;


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

    public void Resume()
    {
        AudioManager.instance.PlaySoundEffects(10);
        GameManager.gameManagerScript.PauseUnPause(); 
    }

    public void MainMenu()
    {
        AudioManager.instance.PlaySoundEffects(10);

        PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "_cp", "");

        //SceneManager.LoadScene("MainMenu");

        Time.timeScale = 1f;

        StartCoroutine(LoadMainMenu());
    }

    public void Quit()
    {
        AudioManager.instance.PlaySoundEffects(10);

        PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "_cp", "");

        Application.Quit();
    }


    public IEnumerator LoadMainMenu()           //Loading Screen menu
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MainMenu");

        asyncLoad.allowSceneActivation = false;

        while(!asyncLoad.isDone)
        {
            if(asyncLoad.progress >= .9f)
            {
                loadingText.text = "Touch the screen!";
                loadingImage.SetActive(false);

                if(Input.anyKeyDown)
                {
                    asyncLoad.allowSceneActivation = true;

                    Time.timeScale = 1f;
                }
            }

            yield return null;
        }
    }


}
