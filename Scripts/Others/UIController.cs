using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    public static UIController UIControllerScript;

    public Slider healthSlider;
    public Text healthText;
    public Text ammoText;

    public Image damageImage;
    public float damageAlpha = 0.25f, damageFadeSpeed = 20f;

    public GameObject pausePanel;

    public Image blackScreen;
    public float fadeSpeed = 1.5f;


    private void Awake()
    {
        UIControllerScript = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damageImage.color.a != 0)
        {
            damageImage.color = new Color(damageImage.color.r, damageImage.color.g, damageImage.color.b, Mathf.MoveTowards(damageImage.color.a, 0f, damageFadeSpeed * Time.deltaTime));
        }

        if (!LevelExit.instance.endLevel)
        {
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
        }
        else
        {
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
        }

        
    }

    public void ShowDamage()
    {
        damageImage.color = new Color(damageImage.color.r, damageImage.color.g, damageImage.color.b, .20f);
    }

    
}
