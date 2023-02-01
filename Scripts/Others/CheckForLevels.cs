using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckForLevels : MonoBehaviour
{
    public static CheckForLevels instance;

    public AudioClip errorSound;
    public AudioClip clearFlagSound;

    public GameObject levelPanel2;
    public GameObject levelPanel3;

    public Button backButton;
    public Button nextButton;
    public Button level1Button;
    public Button level2Button;
    public Button level3Button;
    public Button level4Button;
    public Button level5Button;
    public Button level6Button;
    public Button level7Button;
    public Button level8Button;
    public Button level9Button;
    public Button level10Button;
    public Button level11Button;
    public Button level12Button;
    public Button level13Button;
    public Button level14Button;
    public Button level15Button;
    public Button level16Button;
    public Button level17Button;
    public Button level18Button;
    public Button level19Button;
    public Button level20Button;
    public Button level21Button;
    public Button level22Button;
    public Button level23Button;
    public Button level24Button;
    public Button level25Button;
    public Button level26Button;
    public Button level27Button;
    public Button level28Button;
    public Button level29Button;
    public Button level30Button;

    public GameObject clearFlag1;
    public GameObject clearFlag2;
    public GameObject clearFlag3;
    public GameObject clearFlag4;
    public GameObject clearFlag5;
    public GameObject clearFlag6;
    public GameObject clearFlag7;
    public GameObject clearFlag8;
    public GameObject clearFlag9;
    public GameObject clearFlag10;
    public GameObject clearFlag11;
    public GameObject clearFlag12;
    public GameObject clearFlag13;
    public GameObject clearFlag14;
    public GameObject clearFlag15;
    public GameObject clearFlag16;
    public GameObject clearFlag17;
    public GameObject clearFlag18;
    public GameObject clearFlag19;
    public GameObject clearFlag20;
    public GameObject clearFlag21;
    public GameObject clearFlag22;
    public GameObject clearFlag23;
    public GameObject clearFlag24;
    public GameObject clearFlag25;
    public GameObject clearFlag26;
    public GameObject clearFlag27;
    public GameObject clearFlag28;
    public GameObject clearFlag29;
    public GameObject clearFlag30;

    public bool isStoryMode;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForButtons());
    
        isStoryMode = true;
    }

    // Update is called once per frame
    void Update()
    {
        CheckForUnlock();
    }


    public void CheckForUnlock()
    {
        //Gestione Button Level2
        if(PlayerPrefs.GetInt("level1") == 3)
        {
            clearFlag1.SetActive(true);

            level2Button.interactable = true;
        }
        else
        {
            clearFlag1.SetActive(false);

            level2Button.interactable = false;
        }

        //Gestione Button Level3
        if (PlayerPrefs.GetInt("level2") == 1)
        {
            clearFlag2.SetActive(true);

            level3Button.interactable = true;
        }
        else
        {
            clearFlag2.SetActive(false);

            level3Button.interactable = false;
        }

        //Gestione Button Level4
        if (PlayerPrefs.GetInt("level3") == 1)
        {
            clearFlag3.SetActive(true);

            level4Button.interactable = true;
        }
        else
        {
            clearFlag3.SetActive(false);

            level4Button.interactable = false;
        }

        //Gestione Button Level5
        if (PlayerPrefs.GetInt("level4") == 1)
        {
            clearFlag4.SetActive(true);

            level5Button.interactable = true;
        }
        else
        {
            clearFlag4.SetActive(false);

            level5Button.interactable = false;
        }

        //Gestione Button Level6
        if (PlayerPrefs.GetInt("level5") == 1)
        {
            clearFlag5.SetActive(true);

            level6Button.interactable = true;
        }
        else
        {
            clearFlag5.SetActive(false);

            level6Button.interactable = false;
        }

        //Gestione Button Level7
        if (PlayerPrefs.GetInt("level6") == 1)
        {
            clearFlag6.SetActive(true);

            level7Button.interactable = true;
        }
        else
        {
            clearFlag6.SetActive(false);

            level7Button.interactable = false;
        }

        //Gestione Button Level8
        if (PlayerPrefs.GetInt("level7") == 1)
        {
            clearFlag7.SetActive(true);

            level8Button.interactable = true;
        }
        else
        {
            clearFlag7.SetActive(false);

            level8Button.interactable = false;
        }

        //Gestione Button Level9
        if (PlayerPrefs.GetInt("level8") == 1)
        {
            clearFlag8.SetActive(true);

            level9Button.interactable = true;
        }
        else
        {
            clearFlag8.SetActive(false);

            level9Button.interactable = false;
        }

        //Gestione Button Level10
        if (PlayerPrefs.GetInt("level9") == 1)
        {
            clearFlag9.SetActive(true);

            level10Button.interactable = true;
        }
        else
        {
            clearFlag9.SetActive(false);

            level10Button.interactable = false;
        }

        //Gestione Button Level11
        if (PlayerPrefs.GetInt("level10") == 1 && levelPanel2.activeInHierarchy || PlayerPrefs.GetInt("level10") == 1)
        {
            clearFlag10.SetActive(true);

            level11Button.interactable = true;
        }
        else
        {
            clearFlag10.SetActive(false);

            level11Button.interactable = false;
        }

        //Gestione Button Level12
        if (PlayerPrefs.GetInt("level11") == 1 && levelPanel2.activeInHierarchy)
        {
            clearFlag11.SetActive(true);

            level12Button.interactable = true;
        }
        else
        {
            clearFlag11.SetActive(false);

            level12Button.interactable = false;
        }

        //Gestione Button Level13
        if (PlayerPrefs.GetInt("level12") == 1 && levelPanel2.activeInHierarchy)
        {
            clearFlag12.SetActive(true);

            level13Button.interactable = true;
        }
        else
        {
            clearFlag12.SetActive(false);

            level13Button.interactable = false;
        }

        //Gestione Button Level14
        if (PlayerPrefs.GetInt("level13") == 1 && levelPanel2.activeInHierarchy)
        {
            clearFlag13.SetActive(true);

            level14Button.interactable = true;
        }
        else
        {
            clearFlag13.SetActive(false);

            level14Button.interactable = false;
        }

        //Gestione Button Level15
        if (PlayerPrefs.GetInt("level14") == 1 && levelPanel2.activeInHierarchy)
        {
            clearFlag14.SetActive(true);

            level15Button.interactable = true;
        }
        else
        {
            clearFlag14.SetActive(false);

            level15Button.interactable = false;
        }

        //Gestione Button Level16
        if (PlayerPrefs.GetInt("level15") == 1 && levelPanel2.activeInHierarchy)
        {
            clearFlag15.SetActive(true);

            level16Button.interactable = true;
        }
        else
        {
            clearFlag15.SetActive(false);

            level16Button.interactable = false;
        }

        //Gestione Button Level17
        if (PlayerPrefs.GetInt("level16") == 1 && levelPanel2.activeInHierarchy)
        {
            clearFlag16.SetActive(true);

            level17Button.interactable = true;
        }
        else
        {
            clearFlag16.SetActive(false);

            level17Button.interactable = false;
        }

        //Gestione Button Level18
        if (PlayerPrefs.GetInt("level17") == 1 && levelPanel2.activeInHierarchy)
        {
            clearFlag17.SetActive(true);

            level18Button.interactable = true;
        }
        else
        {
            clearFlag17.SetActive(false);

            level18Button.interactable = false;
        }

        //Gestione Button Level19
        if (PlayerPrefs.GetInt("level18") == 1 && levelPanel2.activeInHierarchy)
        {
            clearFlag18.SetActive(true);

            level19Button.interactable = true;
        }
        else
        {
            clearFlag18.SetActive(false);

            level19Button.interactable = false;
        }

        //Gestione Button Level20
        if (PlayerPrefs.GetInt("level19") == 1 && levelPanel2.activeInHierarchy)
        {
            clearFlag19.SetActive(true);

            level20Button.interactable = true;
        }
        else
        {
            clearFlag19.SetActive(false);

            level20Button.interactable = false;
        }

        //Gestione Button Level21
        if (PlayerPrefs.GetInt("level20") == 2 && levelPanel3.activeInHierarchy || PlayerPrefs.GetInt("level20") == 2)
        {
            clearFlag20.SetActive(true);

            level21Button.interactable = true;
        }
        else
        {
            clearFlag20.SetActive(false);

            level21Button.interactable = false;
        }

        //Gestione Button Level22
        if (PlayerPrefs.GetInt("level21") == 1 && levelPanel3.activeInHierarchy)
        {
            clearFlag21.SetActive(true);

            level22Button.interactable = true;
        }
        else
        {
            clearFlag21.SetActive(false);

            level22Button.interactable = false;
        }

        //Gestione Button Level23
        if (PlayerPrefs.GetInt("level22") == 1 && levelPanel3.activeInHierarchy)
        {
            clearFlag22.SetActive(true);
            
            level23Button.interactable = true;
        }
        else
        {
            clearFlag22.SetActive(false);

            level23Button.interactable = false;
        }

        //Gestione Button Level24
        if (PlayerPrefs.GetInt("level23") == 1 && levelPanel3.activeInHierarchy)
        {
            clearFlag23.SetActive(true);

            level24Button.interactable = true;
        }
        else
        {
            clearFlag23.SetActive(false);

            level24Button.interactable = false;
        }

        //Gestione Button Level25
        if (PlayerPrefs.GetInt("level24") == 1 && levelPanel3.activeInHierarchy)
        {
            clearFlag24.SetActive(true);

            level25Button.interactable = true;
        }
        else
        {
            clearFlag24.SetActive(false);

            level25Button.interactable = false;
        }

        //Gestione Button Level26
        if (PlayerPrefs.GetInt("level25") == 1 && levelPanel3.activeInHierarchy)
        {
            clearFlag25.SetActive(true);

            level26Button.interactable = true;
        }
        else
        {
            clearFlag25.SetActive(false);

            level26Button.interactable = false;
        }

        //Gestione Button Level27
        if (PlayerPrefs.GetInt("level26") == 1 && levelPanel3.activeInHierarchy)
        {
            clearFlag26.SetActive(true);

            level27Button.interactable = true;
        }
        else
        {
            clearFlag26.SetActive(false);

            level27Button.interactable = false;
        }

        //Gestione Button Level28
        if (PlayerPrefs.GetInt("level27") == 1 && levelPanel3.activeInHierarchy)
        {
            clearFlag27.SetActive(true);

            level28Button.interactable = true;
        }
        else
        {
            clearFlag27.SetActive(false);

            level28Button.interactable = false;
        }

        //Gestione Button Level29
        if (PlayerPrefs.GetInt("level28") == 1 && levelPanel3.activeInHierarchy)
        {
            clearFlag28.SetActive(true);

            level29Button.interactable = true;
        }
        else
        {
            clearFlag28.SetActive(false);

            level29Button.interactable = false;
        }

        //Gestione Button Level30
        if (PlayerPrefs.GetInt("level29") == 1 && levelPanel3.activeInHierarchy)
        {
            clearFlag29.SetActive(true);

            level30Button.interactable = true;
        }
        else
        {
            clearFlag29.SetActive(false);

            level30Button.interactable = false;
        }

        if(PlayerPrefs.GetInt("level30") == 1 && levelPanel3.activeInHierarchy || PlayerPrefs.GetInt("Level30") == 1)
        {
            clearFlag30.SetActive(true);
        }
        else
        {
            clearFlag30.SetActive(false);
        }
    }

    IEnumerator WaitForButtons()
    {
        backButton.enabled = false;
        nextButton.enabled = false;
        level1Button.enabled = false;
        level2Button.enabled = false;
        level3Button.enabled = false;
        level4Button.enabled = false;
        level5Button.enabled = false;
        level6Button.enabled = false;
        level7Button.enabled = false;
        level8Button.enabled = false;
        level9Button.enabled = false;
        level10Button.enabled = false;

        yield return new WaitForSeconds(0.75f);

        backButton.enabled = true;
        nextButton.enabled = true;
        level1Button.enabled = true;
        level2Button.enabled = true;
        level3Button.enabled = true;
        level4Button.enabled = true;
        level5Button.enabled = true;
        level6Button.enabled = true;
        level7Button.enabled = true;
        level8Button.enabled = true;
        level9Button.enabled = true;
        level10Button.enabled = true;
    }
}
