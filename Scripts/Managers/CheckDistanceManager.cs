using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDistanceManager : MonoBehaviour
{
    public static CheckDistanceManager instance;

    private void Awake()
    {
        instance = this;
    }

    public Transform player;

    public float dist;

    private void FixedUpdate()
    {
        CalculateDistance();
    }

    public void CalculateDistance()
    {
        if(player)
        {
            dist = Vector3.Distance(player.transform.position, gameObject.transform.position);
        }
    }
}
