using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    public int damage = 25;

    public bool damageEnemy, damagePlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && damageEnemy)
        {
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<EnemyHealtController>().DamageEnemy(damage);
        }

     

        if (other.gameObject.tag == "Player" && damagePlayer)
        {
            //other.gameObject.GetComponent<PlayerHealtController>().DamagePlayer(damage);
            PlayerHealtController.playerHealt.DamagePlayer(damage);
        }
      
    }
}
