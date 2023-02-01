using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public GameObject loadingScreen, loadingImage;

    public Text loadingText;

    public AudioClip sfxClick;

    

    public static LevelSelection instance;

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

    public void ReturnToMenu()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        StartCoroutine(LoadMenu());
    }

    public void FinalScene()
    {
        SceneManager.LoadScene("EndGame1");
    }

    public void PlayStart1()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        StartCoroutine(LoadStart1());
    }

    public void PlayLv1()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if(PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv1LQ());
        }

        if(PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv1());
        }
    }

    public void PlayLv2()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv2LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv2());
        }

    }

    public void PlayLv3()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv3LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv3());
        }

    }

    public void PlayLv4()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv4LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv4());
        }

    }

    public void PlayLv5()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv5LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv5());
        }

    }

    public void PlayLv6()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv6LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv6());
        }

    }

    public void PlayLv7()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv7LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv7());
        }

    }

    public void PlayLv8()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv8LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv8());
        }
    }

    public void PlayLv9()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv9LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv9());
        }
    }

    public void PlayLv10()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv10LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv10());
        }
    }

    public void PlayLv11()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv11LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv11());
        }
    }

    public void PlayLv12()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv12LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv12());
        }
    }

    public void PlayLv13()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv13LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv13());
        }
    }

    public void PlayLv14()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv14LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv14());
        }
    }

    public void PlayLv15()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv15LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv15());
        }
    }

    public void PlayLv16()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv16LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv16());
        }
    }

    public void PlayLv17()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv17LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv17());
        }
    }

    public void PlayLv18()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv18LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv18());
        }
    }

    public void PlayLv19()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv19LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv19());
        }
    }

    public void PlayLv20()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv20LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv20());
        }
    }

    public void PlayLv21()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv21LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv21());
        }
    }

    public void PlayLv22()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv22LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv22());
        }
    }

    public void PlayLv23()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv23LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv23());
        }
    }

    public void PlayLv24()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv24LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv24());
        }
    }

    public void PlayLv25()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv25LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv25());
        }
    }

    public void PlayLv26()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv26LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv26());
        }
    }

    public void PlayLv27()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv27LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv27());
        }
    }

    public void PlayLv28()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);

        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv28LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv28());
        }
    }

    public void PlayLv29()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);


        if (PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv29LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv29());
        }
    }

    public void Play30()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 0.5f);


        if(PlayerPrefs.GetInt("QualityLevel") == 0)
        {
            StartCoroutine(LoadLv30LQ());
        }

        if (PlayerPrefs.GetInt("QualityLevel") == 1)
        {
            StartCoroutine(LoadLv30());
        }
    }

    public IEnumerator LoadStart1()           //Loading Start1
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Start1");

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


    public IEnumerator LoadMenu()           //Loading Menu
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

    public IEnumerator LoadLv1()           //Loading Screen 1
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level1");

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

    public IEnumerator LoadLv1LQ()           //Loading Screen 1 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level1LQ");

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


    public IEnumerator LoadLv2()           //Loading Screen 2
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level2");

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

    public IEnumerator LoadLv2LQ()           //Loading Screen 2 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level2LQ");

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


    public IEnumerator LoadLv3()           //Loading Screen 3
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level3");

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

    public IEnumerator LoadLv3LQ()           //Loading Screen 3 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level3LQ");

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


    public IEnumerator LoadLv4()           //Loading Screen 4
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level4");

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

    public IEnumerator LoadLv4LQ()           //Loading Screen 4 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level4LQ");

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

    public IEnumerator LoadLv5()           //Loading Screen 5
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level5");

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

    public IEnumerator LoadLv5LQ()           //Loading Screen 5 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level5LQ");

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


    public IEnumerator LoadLv6()           //Loading Screen 6
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level6");

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

    public IEnumerator LoadLv6LQ()           //Loading Screen 6 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level6LQ");

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

    public IEnumerator LoadLv7()           //Loading Screen 7
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level7");

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

    public IEnumerator LoadLv7LQ()           //Loading Screen 7 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level7LQ");

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


    public IEnumerator LoadLv8()           //Loading Screen 8
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level8");

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

    public IEnumerator LoadLv8LQ()           //Loading Screen 8 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level8LQ");

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


    public IEnumerator LoadLv9()           //Loading Screen 9
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level9");

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

    public IEnumerator LoadLv9LQ()           //Loading Screen 9 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level9LQ");

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


    public IEnumerator LoadLv10()           //Loading Screen 10
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level10");

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

    public IEnumerator LoadLv10LQ()           //Loading Screen 10 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level10LQ");

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


    public IEnumerator LoadLv11()           //Loading Screen 11
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level11");

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

    public IEnumerator LoadLv11LQ()           //Loading Screen 11 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level11LQ");

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


    public IEnumerator LoadLv12()           //Loading Screen 12
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level12");

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

    public IEnumerator LoadLv12LQ()           //Loading Screen 12 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level12LQ");

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


    public IEnumerator LoadLv13()           //Loading Screen 13
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level13");

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

    public IEnumerator LoadLv13LQ()           //Loading Screen 13 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level13LQ");

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


    public IEnumerator LoadLv14()           //Loading Screen 14
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level14");

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

    public IEnumerator LoadLv14LQ()           //Loading Screen 14 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level14LQ");

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


    public IEnumerator LoadLv15()           //Loading Screen 15
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level15");

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

    public IEnumerator LoadLv15LQ()           //Loading Screen 15 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level15LQ");

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


    public IEnumerator LoadLv16()           //Loading Screen 16
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level16");

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

    public IEnumerator LoadLv16LQ()           //Loading Screen  16 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level16LQ");

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


    public IEnumerator LoadLv17()           //Loading Screen 17
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level17");

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

    public IEnumerator LoadLv17LQ()           //Loading Screen 17 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level17LQ");

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


    public IEnumerator LoadLv18()           //Loading Screen 18
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level18");

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

    public IEnumerator LoadLv18LQ()           //Loading Screen 18 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level18LQ");

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



    public IEnumerator LoadLv19()           //Loading Screen 19
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level19");

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

    public IEnumerator LoadLv19LQ()           //Loading Screen 19 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level19LQ");

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

    public IEnumerator LoadLv20()           //Loading Screen 20
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level20");

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

    public IEnumerator LoadLv20LQ()           //Loading Screen 20 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level20LQ");

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

    public IEnumerator LoadLv21()           //Loading Screen 21
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level21");

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

    public IEnumerator LoadLv21LQ()           //Loading Screen 21 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level21LQ");

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


    public IEnumerator LoadLv22()           //Loading Screen 22
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level22");

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

    public IEnumerator LoadLv22LQ()           //Loading Screen 22 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level22LQ");

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


    public IEnumerator LoadLv23()           //Loading Screen 23
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level23");

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

    public IEnumerator LoadLv23LQ()           //Loading Screen 23 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level23LQ");

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


    public IEnumerator LoadLv24()           //Loading Screen 24
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level24");

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

    public IEnumerator LoadLv24LQ()           //Loading Screen24  LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level24LQ");

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


    public IEnumerator LoadLv25()           //Loading Screen 25
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level25");

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

    public IEnumerator LoadLv25LQ()           //Loading Screen 25 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level25LQ");

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


    public IEnumerator LoadLv26()           //Loading Screen 26
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level26");

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

    public IEnumerator LoadLv26LQ()           //Loading Screen 26 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level26LQ");

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


    public IEnumerator LoadLv27()           //Loading Screen 27
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level27");

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

    public IEnumerator LoadLv27LQ()           //Loading Screen 27 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level27LQ");

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


    public IEnumerator LoadLv28()           //Loading Screen 28
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level28");

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

    public IEnumerator LoadLv28LQ()           //Loading Screen 28 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level28LQ");

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

    public IEnumerator LoadLv29()           //Loading Screen 29
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level29");

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

    public IEnumerator LoadLv29LQ()           //Loading Screen 29 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level29LQ");

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


    public IEnumerator LoadLv30()           //Loading Screen 30
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level30");

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

    public IEnumerator LoadLv30LQ()           //Loading Screen 30 LQ
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level30LQ");

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
