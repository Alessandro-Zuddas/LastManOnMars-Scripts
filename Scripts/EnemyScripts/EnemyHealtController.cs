using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealtController : MonoBehaviour
{
    public int currentHealt = 5;

    public GameObject dieEffect;

    public GameObject[] allDeathsSounds;
    //public GameObject enemy;

    public bool wasDead;

    public EnemyController enemyController;

    public Transform player;

    public float dist;


    // Start is called before the first frame update
    void Start()
    {
        wasDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        CalculateDistance();
    }



    public void DamageEnemy(int damageAmount)
    {
        currentHealt -= damageAmount;

        if(enemyController != null)
        {
            enemyController.GetShot();
        }

        if (currentHealt <= 0 && !wasDead)
        {
            if (dist <= 30)
            {         
                AudioManager.instance.PlayDeath();

                StartCoroutine(EnemyDieCoroutine());
            }
            else
            {
                Destroy(gameObject);

                Instantiate(dieEffect, gameObject.transform.position, Quaternion.identity);
            }
        }
    }

    public IEnumerator EnemyDieCoroutine()
    {
        wasDead = true;      

        yield return new WaitForSeconds(0.5f); 

        Destroy(gameObject);

        Instantiate(dieEffect, gameObject.transform.position, Quaternion.identity);
    }

    public void CalculateDistance()
    {
        if (player)
        {
            dist = Vector3.Distance(player.transform.position, gameObject.transform.position);
        }
    }

}
