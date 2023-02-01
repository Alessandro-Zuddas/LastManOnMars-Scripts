using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    private bool chasing;

    public float distanceToChase = 10f, distanceToLose = 15f, distanceToStop = 2f;

    private Vector3 targetPoint, startPoint;

    public NavMeshAgent agent;

    public float keepChasingTime = 5f;
    private float chaseCounter;

    public GameObject bullet;
    public Transform firePoint;

    public float fireRate, waitBetweenShots = 1.5f, timeToShoot = 1.2f;
    private float fireCount, shotWaitCounter, shootTimeCounter;

    public Animator animator;

    private bool wasShot;

    public static EnemyController instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position;

        shootTimeCounter = timeToShoot;
        shotWaitCounter = waitBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
        CheckForShots();            //Copiare su IOS

        targetPoint = PlayerController.playerController.transform.position;

        targetPoint.y = transform.position.y;

        if(!chasing)
        {
            if(Vector3.Distance(transform.position, targetPoint) < distanceToChase)
            {
                chasing = true;

                shootTimeCounter = timeToShoot;
                shotWaitCounter = waitBetweenShots;
            }

            if(chaseCounter > 0)
            {
                chaseCounter -= Time.deltaTime;

                if (chaseCounter <= 0)
                {
                    agent.destination = startPoint;
                }
            }

            if(agent.remainingDistance < 0.25f)
            {
                animator.SetBool("isMoving", false);
            }
            else
            {
                animator.SetBool("isMoving", true);
            }

        }
        else
        {
            //transform.LookAt(targetPoint);

            //rigidBody.velocity = transform.forward * moveSpeed;

            if(Vector3.Distance(transform.position, targetPoint) > distanceToStop)
            {
                agent.destination = targetPoint;
            }
            else
            {
                agent.destination = transform.position;
            }
                   

            if (Vector3.Distance(transform.position, targetPoint) > distanceToChase)
            {
                if(!wasShot)
                {
                    chasing = false;

                    chaseCounter = keepChasingTime;
                }

                
            }
            else
            {
                wasShot = false;
            }

            if (shotWaitCounter > 0)   
            {
                shotWaitCounter -= Time.deltaTime;

                if (shotWaitCounter <= 0)
                {
                    shootTimeCounter = timeToShoot;
                }

                animator.SetBool("isMoving", true);

            }
            else
            {
                if (PlayerController.playerController.gameObject.activeInHierarchy)
                {



                    shootTimeCounter -= Time.deltaTime;

                    if (shootTimeCounter > 0)
                    {
                        fireCount -= Time.deltaTime;

                        if (fireCount <= 0)
                        {
                            fireCount = fireRate;


                            firePoint.LookAt(PlayerController.playerController.transform.position + new Vector3(0, 1.5f, 0));

                            //Controllo l'angolo tra il player e il nemico

                            Vector3 targetDir = PlayerController.playerController.transform.position - transform.position;
                            float angle = Vector3.SignedAngle(targetDir, transform.forward, Vector3.up);

                            if (Mathf.Abs(angle) < 30f)
                            {
                                Instantiate(bullet, firePoint.position, firePoint.rotation);

                                animator.SetTrigger("fireShot");
                            }
                            else
                            {
                                shotWaitCounter = waitBetweenShots;
                            }


                        }

                        agent.destination = transform.position;

                    }
                    else
                    {
                        shotWaitCounter = waitBetweenShots;
                    }


                }
                        animator.SetBool("isMoving", false);

            }
        }

    }

    public void GetShot()
    {
        wasShot = true;

        chasing = true; 
    }

    private void CheckForShots()   //Copiare su IOS
    {
        if(wasShot)
        {
            animator.SetBool("wasShot", true);
        }

        if(!wasShot)
        {
            animator.SetBool("wasShot", false);
        }
    }
}
