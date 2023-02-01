using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public GameObject bullet;

    public float rangeToTarget;
    public float timeBetweenShots = 0.5f;
    private float shotCounter;

    public float rotateSpeed = 2.5f;

    public Transform gun, firePoint, firePoint2;


    // Start is called before the first frame update
    void Start()
    {
        shotCounter = timeBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, PlayerController.playerController.transform.position) < rangeToTarget)
        {
            gun.LookAt(PlayerController.playerController.transform.position + new Vector3(0f, 1.2f, 0f));

            shotCounter -= Time.deltaTime;

            if(shotCounter <= 0)
            {
                Instantiate(bullet, firePoint.position, firePoint.rotation);

                shotCounter = timeBetweenShots;
            }
        }
        else
        {
            shotCounter = timeBetweenShots;

            gun.rotation = Quaternion.Lerp(gun.rotation, Quaternion.Euler(0f, gun.rotation.eulerAngles.y + 10f, 0f), rotateSpeed * Time.deltaTime);
        }


        if (Vector3.Distance(transform.position, PlayerController.playerController.transform.position) < rangeToTarget)
        {
            gun.LookAt(PlayerController.playerController.transform.position + new Vector3(0f, 1.2f, 0f));

            shotCounter -= Time.deltaTime;

            if (shotCounter <= 0)
            {
                Instantiate(bullet, firePoint2.position, firePoint2.rotation);

                shotCounter = timeBetweenShots;
            }
        }
        else
        {
            shotCounter = timeBetweenShots;

            gun.rotation = Quaternion.Lerp(gun.rotation, Quaternion.Euler(0f, gun.rotation.eulerAngles.y + 10f, 0f), rotateSpeed * Time.deltaTime);
        }
    }
}
