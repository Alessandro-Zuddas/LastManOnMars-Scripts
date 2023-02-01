using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealtControllerOnline : MonoBehaviour
{
    public static PlayerHealtControllerOnline instance;
    public int maxHealt, currentHealt;

    public float invincibleLength = 1f;
    public float inviCounter;



    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        currentHealt = maxHealt;

        UIController.UIControllerScript.healthSlider.maxValue = maxHealt;
        UIController.UIControllerScript.healthSlider.value = currentHealt;
        UIController.UIControllerScript.healthText.text = "Health: " + currentHealt + "/" + maxHealt;
    }

    // Update is called once per frame
    void Update()
    {
        if (inviCounter > 0)
        {
            inviCounter -= Time.deltaTime;
        }
    }

    public void DamagePlayer(int damageAmount)
    {
        if (inviCounter <= 0)
        {
            AudioManager.instance.PlaySoundEffects(7);

            currentHealt -= damageAmount;

            UIController.UIControllerScript.ShowDamage();

            if (currentHealt <= 0)
            {
                UIController.UIControllerScript.healthSlider.value = currentHealt;
                UIController.UIControllerScript.healthText.text = "Health: " + currentHealt + "/" + maxHealt;

                currentHealt = 0;

                gameObject.SetActive(false);

                GameManager.gameManagerScript.PlayerDied();

                AudioManager.instance.StopMusic();

                AudioManager.instance.PlaySoundEffects(6);
                AudioManager.instance.StopSoundEffects(7);
            }

            inviCounter = invincibleLength;

            UIController.UIControllerScript.healthSlider.value = currentHealt;
            UIController.UIControllerScript.healthText.text = "Health: " + currentHealt + "/" + maxHealt;
        }
    }


    public void HealPlayer(int healAmount)
    {
        currentHealt += healAmount;

        if (currentHealt > maxHealt)
        {
            currentHealt = maxHealt;
        }

        UIController.UIControllerScript.healthSlider.value = currentHealt;
        UIController.UIControllerScript.healthText.text = "Health: " + currentHealt + "/" + maxHealt;
    }
}
