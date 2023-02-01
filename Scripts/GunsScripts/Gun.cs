using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletOnline;

    public bool canAutoFire;

    public float fireRate;

    public int currentAmmo, pickupAmount;

    [HideInInspector]
    public float fireCounter;

    public Transform firePoint;

    public float zoomAmount;

    public string gunName;

    public int shotDamage;
    public int damage;

    public static Gun instance;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        damage = shotDamage;
    }

    // Update is called once per frame
    void Update()
    {
        if(fireCounter > 0)
        {
            fireCounter -= Time.deltaTime;
        }
    }

    public void GetAmmo()
    {
        currentAmmo += pickupAmount;

        UIController.UIControllerScript.ammoText.text = "Ammo: " + currentAmmo;
    }

}
