using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class HealthPickupOnline : MonoBehaviourPunCallbacks
{
    public static HealthPickupOnline instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //BulletOnline.instance.CallHealPlayer();

            Debug.Log("Chiamato CallHealPlayer()");

            AudioManager.instance.PlaySoundEffects(5);

            PhotonNetwork.Destroy(gameObject);
        }
    }
}
