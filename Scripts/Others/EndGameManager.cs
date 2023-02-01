using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    public GameObject endGameText1;
    public GameObject endGameText2;
    public GameObject menuButton;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndGame1Coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EndGame1Coroutine()
    {
        endGameText1.SetActive(true);

        yield return new WaitForSeconds(3f);

        endGameText1.SetActive(false);

        yield return new WaitForSeconds(2f);

        endGameText2.SetActive(true);

        yield return new WaitForSeconds(1f);

        menuButton.SetActive(true);

    }
}
