using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    public string nextLevel;

    public string currentLevel;

    public float waitToEndLevel;

    public bool endLevel;

    public static LevelExit instance;

   


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        endLevel = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            endLevel = true;

            StartCoroutine(EndLevelCoroutine());

            AudioManager.instance.PlayLevelVictory();    //Da cambiare
        }
    }

    private IEnumerator EndLevelCoroutine()
    {
        PlayerPrefs.SetString(nextLevel + "_cp", "");
        PlayerPrefs.SetString(currentLevel + "_cp", "");

        yield return new WaitForSeconds(waitToEndLevel);
                
        SceneManager.LoadScene(nextLevel);
    }

}
