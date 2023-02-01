using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPickup : MonoBehaviour
{
    public string theGun;

    private bool collected;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !collected)
        {
            PlayerController.playerController.AddGun(theGun);

            Destroy(gameObject);

            collected = true;

            AudioManager.instance.PlaySoundEffects(4);
        }
    }
}