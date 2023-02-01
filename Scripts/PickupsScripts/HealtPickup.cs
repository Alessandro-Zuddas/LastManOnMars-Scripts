using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtPickup : MonoBehaviour
{
    public int healAmount;

    private bool isCollected;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !isCollected)
        {
            PlayerHealtController.playerHealt.HealPlayer(healAmount);

            Destroy(gameObject);

            AudioManager.instance.PlaySoundEffects(5);
        }
    }

}
