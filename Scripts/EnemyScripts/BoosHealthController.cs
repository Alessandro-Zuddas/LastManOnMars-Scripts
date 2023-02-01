using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoosHealthController : MonoBehaviour
{
    public Slider bossLifeSlider;

    public int maxBossHealth = 50;
    public int bossHealt = 50;
    public int currentBossHealt;

    public Text bossHealthText;

    public static BoosHealthController instance;

    public EnemyController enemyController;

    public GameObject bossDieEffect;

    public bool wasDead;


    public Transform player;

    public float dist;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        wasDead = false;

       if(bossLifeSlider.IsActive())
       {
            currentBossHealt = bossHealt;
            bossLifeSlider.value = currentBossHealt;
            bossHealthText.text = "Boss health: " + currentBossHealt + "/" + bossHealt;
       }
    }

    // Update is called once per frame
    void Update()
    {
        CalculateDistance(); 
    }

    public void DamageBoss(int damageAmount)
    {
        bossHealt -= damageAmount;

        if (enemyController != null)
        {
            enemyController.GetShot();
        }

        if (bossHealt <= 0 && !wasDead)
        {
            if (dist <= 75)
            {
                AudioManager.instance.PlayDeath();

                StartCoroutine(EnemyDieCoroutine());
            }
            else
            {
                Destroy(gameObject);

                Instantiate(bossDieEffect, gameObject.transform.position, Quaternion.identity);
            }
        }

        bossLifeSlider.value = bossHealt;
        bossHealthText.text = "Boss health: " + bossHealt + "/" + currentBossHealt;
    }

    public IEnumerator EnemyDieCoroutine()
    {
        wasDead = true;

        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);

        Instantiate(bossDieEffect, gameObject.transform.position, Quaternion.identity);
    }

    public void CalculateDistance()
    {
        if (player)
        {
            dist = Vector3.Distance(player.transform.position, gameObject.transform.position);
        }
    }
}
