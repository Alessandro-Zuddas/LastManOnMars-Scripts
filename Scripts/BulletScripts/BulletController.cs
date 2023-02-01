using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float moveSpeed, bulletLifeTime;


    public Rigidbody rigidBody;

    public GameObject impactEffect;

    public int damage = 1;
    public int damagex2 = 2;

    public bool damageEnemy, damagePlayer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = transform.forward * moveSpeed;

        bulletLifeTime -= Time.deltaTime;

        if(bulletLifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy" && damageEnemy)
        {
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<EnemyHealtController>().DamageEnemy(damage);
        }

        if (other.gameObject.tag == "Turret" && damageEnemy)
        {
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<TurretHealthScript>().DamageEnemy(damage);
        }

        if (other.gameObject.tag == "HeadShot" && damageEnemy)
        {
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<EnemyHealtController>().DamageEnemy(damagex2);
            Debug.Log("Danno Doppio!");
        }

        if (other.gameObject.tag == "Player" && damagePlayer)
        {
            //other.gameObject.GetComponent<PlayerHealtController>().DamagePlayer(damage);
            PlayerHealtController.playerHealt.DamagePlayer(damage);
        }

        if (other.gameObject.tag == "Boss" && damageEnemy)
        {
            //Destroy(other.gameObject);
            BoosHealthController.instance.DamageBoss(damage);
        }

        if(other.gameObject.layer == 3)
        {
            Destroy(gameObject);

            Instantiate(impactEffect, gameObject.transform.position, Quaternion.identity);
        }


        Destroy(gameObject);
        Instantiate(impactEffect, transform.position + (transform.forward * (-moveSpeed * Time.deltaTime)), transform.rotation);
    }
}
