using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PanelSelectionScript : MonoBehaviour
{
    public int currentPanelIndex = 0;

    public GameObject firstPanel;
    public GameObject secondPanel;
    public GameObject thirdPanel;

    public AudioClip clickSound;

    public static PanelSelectionScript instance;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        firstPanel.SetActive(true);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPanelIndex == 0)
        {
            firstPanel.SetActive(true);
            secondPanel.SetActive(false);
            thirdPanel.SetActive(false);
        }

        if (currentPanelIndex == 1)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(true);
            thirdPanel.SetActive(false);
        }

        if (currentPanelIndex == 2)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(false);
            thirdPanel.SetActive(true);
        }
    }

    public void ChangeNext()
    {
        GetComponent<AudioSource>().PlayOneShot(clickSound);

        currentPanelIndex++;
    }

    public void ChangeBack()
    {
        GetComponent<AudioSource>().PlayOneShot(clickSound);

        currentPanelIndex--;
    }
}
