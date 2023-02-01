using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePadScript : MonoBehaviour
{
    public float bounceForce;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController.playerController.Bounce(bounceForce);

            PlayerController.playerController.verticalVelocity = bounceForce;

            AudioManager.instance.PlaySoundEffects(0);
        }
    }


}
