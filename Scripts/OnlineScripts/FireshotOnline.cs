using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireshotOnline : MonoBehaviour
{
    public float moveSpeed, bulletLifeTime;

    public Rigidbody rigidBody;

    public GameObject impactEffect;

    //public int damage = 1;

    public static FireshotOnline instance;

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
        rigidBody.velocity = transform.forward * moveSpeed;

        bulletLifeTime -= Time.deltaTime;

        if (bulletLifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            Destroy(gameObject);  

            Instantiate(impactEffect, gameObject.transform.position, Quaternion.identity);
        }

        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);  

            Instantiate(impactEffect, gameObject.transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
        Instantiate(impactEffect, transform.position + (transform.forward * (-moveSpeed * Time.deltaTime)), transform.rotation);
    }

}
