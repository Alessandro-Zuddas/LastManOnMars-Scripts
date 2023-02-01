using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class AmmoPickupOnline : MonoBehaviourPunCallbacks
{
    public static AmmoPickupOnline instance;

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
            //BulletOnline.instance.CallGetAmmo();

            Debug.Log("Chiamato CallGetAmmo()");

            AudioManager.instance.PlaySoundEffects(3);

            PhotonNetwork.Destroy(gameObject);
        }      
    }
}
