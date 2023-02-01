using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupsManager : MonoBehaviour
{
    public static PickupsManager instance;

    public Transform[] pickupSpawnPoints;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform spawn in pickupSpawnPoints)
        {
            spawn.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Transform GetSpawnPoint()
    {
        return pickupSpawnPoints[Random.Range(0, pickupSpawnPoints.Length)];
    }
}