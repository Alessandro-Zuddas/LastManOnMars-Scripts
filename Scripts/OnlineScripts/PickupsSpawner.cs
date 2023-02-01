using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class PickupsSpawner : MonoBehaviour
{
    public static PickupsSpawner instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject pickupsPrefab1;
    private GameObject pickup1;

    public GameObject pickupsPrefab2;
    private GameObject pickup2;

    public bool notSpawned1;
    public bool notSpawned2;
    public bool notSpawned3;
    public bool notSpawned4;
    public bool notSpawned5;

    public float matchTime;

    // Start is called before the first frame update
    void Start()
    {
        matchTime = MatchManager.instance.matchLength;

        notSpawned1 = true;
        notSpawned2 = true;
        notSpawned3 = true;
        notSpawned4 = true;
        notSpawned5 = true;
    }

    private void Update()
    {
        if (matchTime > 0)
        {
            matchTime -= Time.deltaTime;
        }
        else
        {
            matchTime = 0;
        }

        if (matchTime <= 500 && notSpawned1)
        {
            SpawnHealthPickups();
            SpawnAmmoPickups();

            notSpawned1 = false;
        }

        if (matchTime <= 400 && notSpawned2)
        {
            SpawnHealthPickups();
            SpawnAmmoPickups();

            notSpawned2 = false;
        }

        if (matchTime <= 300 && notSpawned3)
        {
            SpawnHealthPickups();
            SpawnAmmoPickups();

            notSpawned3 = false;
        }

        if (matchTime <= 200 && notSpawned4)
        {
            SpawnHealthPickups();
            SpawnAmmoPickups();

            notSpawned4 = false;
        }

        if (matchTime <= 100 && notSpawned5)
        {
            SpawnHealthPickups();
            SpawnAmmoPickups();

            notSpawned5 = false;
        }
    }

    public void SpawnHealthPickups()
    {
        Transform pickupSpawnPoint = PickupsManager.instance.GetSpawnPoint();

        pickup1 = PhotonNetwork.Instantiate(pickupsPrefab1.name, pickupSpawnPoint.position, pickupSpawnPoint.rotation);
    }

    public void SpawnAmmoPickups()
    {
        Transform pickupSpawnPoint = PickupsManager.instance.GetSpawnPoint();

        pickup2 = PhotonNetwork.Instantiate(pickupsPrefab2.name, pickupSpawnPoint.position, pickupSpawnPoint.rotation);
    }
}
