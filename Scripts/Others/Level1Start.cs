using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Start : MonoBehaviour
{
    public float timeBetweenShowing = 2.5f;

    public GameObject textBox, textBox2, nextLevelButton;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowTextCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator ShowTextCoroutine()
    {
        yield return new WaitForSeconds(timeBetweenShowing);

        textBox.SetActive(true);

        yield return new WaitForSeconds(timeBetweenShowing);

        textBox2.SetActive(true);

        yield return new WaitForSeconds(timeBetweenShowing);

        nextLevelButton.SetActive(true);
    }
}
