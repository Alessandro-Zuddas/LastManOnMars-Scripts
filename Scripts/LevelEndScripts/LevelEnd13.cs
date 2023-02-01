using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelEnd13 : MonoBehaviour
{

    public float timeBetweenShowing = 1f;

    public GameObject textBox, textBox2, menuButton, nextLevelButton;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowTextCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void MainMenu()
    {
        PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "_cp", "");

        SceneManager.LoadScene("MainMenu");

        //StartCoroutine(PauseScreenScript.instance.LoadMainMenu());
    }


    public IEnumerator ShowTextCoroutine()
    {
        yield return new WaitForSeconds(timeBetweenShowing);

        textBox.SetActive(true);

        yield return new WaitForSeconds(timeBetweenShowing);

        textBox2.SetActive(true);

        PlayerPrefs.SetInt("level13", 1);

        yield return new WaitForSeconds(timeBetweenShowing);

        menuButton.SetActive(true);

        nextLevelButton.SetActive(true);
    }



}