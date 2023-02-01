using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Photon.Pun;


public class PlayerController : MonoBehaviourPunCallbacks
{
    public GameObject switchGun;

    public bool isFiring;

    //References
    public CharacterController characterController;

    [Header("Gravity & Jumping")]
    public float stickToGroundForce = 10;
    public float gravity = 10;
    private float jumpSpeed = 10;

    public float verticalVelocity;


    [Header("Ground Check")]
    public Transform groundCheck;
    public LayerMask groundLayers;
    public float groundCheckRadius;

    public bool grounded;

    public float moveSpeed, gravityModifier, jumpPower;
    public float runSpeed = 12;

    
    

    public CharacterController charCon;

    private Vector3 moveInput;

    public Transform camTransform;

    public float mouseSensitivity;

    public bool invertX;
    public bool invertY;
    private bool canJump;
    private bool canDoubleJump;
    

    public int zoomIsIn;


    public Transform groundCheckPoint;
    public LayerMask whatIsGrounded;
    public Animator anim;

    //public GameObject bullet;
    public Transform firePoint;

    public Gun activeGun;
    public List<Gun> allGuns = new List<Gun>();
    public int currentGunIndex;

    public List<Gun> unlockableGuns = new List<Gun>();

    public GameObject shotButton;

    public GameObject zoomOnPanel;
    public GameObject zoomOutPanel;

    public Transform aimDSPoint, gunHolder;
    public Vector3 gunStartPos;
    public float aimDsSpeed = 2f;

    public GameObject muzzleFlash;

    public AudioSource footStep;

    private float bounceAmount;
    private bool bounce;
    public float shotCounter;
    public float timeBetweenShots = .1f;

    public float maxHeatValue = 15f;
    public float heatPerShot = 1f;
    public float coolRate = 4f;
    public float overHeatCoolRate = 5f;
    public float heatCounter;
    public bool isOverHeated;

    public GameObject overHeatMessage;
    public GameObject warningImage;

    public Slider heatControlSlider;
    public GameObject heatControlPanel;

    PhotonView view;

    public static PlayerController playerController;

    

    private void Awake()
    {
        if(playerController == null)
        {
            playerController = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        currentGunIndex--;

       
        SwitchGun();
        
       
        
        zoomOnPanel.SetActive(true);
        zoomOutPanel.SetActive(false);


        gunStartPos = gunHolder.localPosition;

        heatControlSlider.maxValue = maxHeatValue;
        
    }

    // Update is called once per frame
    void Update()
    {
        //IF UNITY STANDALONE------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

#if UNITY_EDITOR_WIN

        Debug.Log("hello unity editor");

        //Conserva la velocità di Y
        float yStore = moveInput.y;


        //Per riconoscere la posizione locale del player e continuare a farlo muovere correttamente
        Vector3 vertMove = transform.forward * Input.GetAxis("Vertical");
        Vector3 horiMove = transform.right * Input.GetAxis("Horizontal");

        moveInput = horiMove + vertMove;
        moveInput.Normalize();                      //Per essere sicuri che movimenti combinati non sommino velocità
        moveInput = moveInput * moveSpeed;

        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveInput = moveInput * runSpeed;
            anim.SetBool("onRunning", true);
        }
        else
        {
            moveInput = moveInput * moveSpeed;
            anim.SetBool("onRunning", false);
            anim.SetFloat("moveSpeed", moveInput.magnitude);
        }

        moveInput.y = yStore;

        moveInput.y += Physics.gravity.y * gravityModifier * Time.deltaTime;

        if(charCon.isGrounded)
        {
            moveInput.y = Physics.gravity.y * gravityModifier * Time.deltaTime;
        }

        canJump = Physics.OverlapSphere(groundCheckPoint.position, .25f, whatIsGrounded).Length > 0;

        if(canJump)
        {
            canDoubleJump = false;
        }

        //Handle Jumping
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            Jump();
        }



        charCon.Move(moveInput * Time.deltaTime);


        //Controllo rotazione Main Camera

        Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * mouseSensitivity;

        if(invertX)
        {
            mouseInput.x = -mouseInput.x;
        }

        if(invertY)
        {
            mouseInput.y = -mouseInput.y;
        }

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);

        camTransform.rotation = Quaternion.Euler(camTransform.rotation.eulerAngles + new Vector3(-mouseInput.y, 0f, 0f));

        
        anim.SetBool("onGround", canJump);


#endif  
        //ENDIF UNITY STANDALONE--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        //Movimento Mobile

        Move();

        //Disattivo MuzzleFlash
        muzzleFlash.SetActive(false);

        //Check For Zoom
        zoomIsIn = PlayerPrefs.GetInt("zoomIsIn");

        if (zoomIsIn == 1)
        {
            gunHolder.position = Vector3.MoveTowards(gunHolder.position, aimDSPoint.position, aimDsSpeed * Time.deltaTime);
            switchGun.SetActive(false);
        }
        else
        {
            gunHolder.localPosition = Vector3.MoveTowards(gunHolder.localPosition, gunStartPos, aimDsSpeed * Time.deltaTime);
            switchGun.SetActive(true);
        }

        //Shot repeating gun con surriscaldamento
        if (Input.GetMouseButtonDown(0) && currentGunIndex == 1)  
        {
            if(!isOverHeated)
            {
                if (isFiring)
                {
                    Shoot();
                }

                heatCounter -= coolRate * Time.deltaTime;
            }
            else
            {
                heatCounter -= overHeatCoolRate * Time.deltaTime;


                if (heatCounter <= 0)
                {
                    isOverHeated = false;
                }

            }

            if(heatCounter < 0)
            {
                heatCounter = 0;
            }

            heatControlSlider.value = heatCounter;
        }

        if(isOverHeated && currentGunIndex == 1)
        {
            overHeatMessage.SetActive(true);
            warningImage.SetActive(true);
        }
        else
        {
            overHeatMessage.SetActive(false);
            warningImage.SetActive(false);
        }

        if(currentGunIndex == 1)
        {
            heatControlPanel.SetActive(true);
        }
        else
        {
            heatControlPanel.SetActive(false); 
        }


        if (Input.GetMouseButton(0))
        {
            Shooting();
        }
        
    }

    private void FixedUpdate()
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayers);
    }


    private void Move()
    {
        if (grounded && verticalVelocity <= 0) verticalVelocity = -stickToGroundForce * Time.deltaTime;
        else verticalVelocity -= gravity * Time.deltaTime;

        Vector3 verticalMovement = transform.up * verticalVelocity;
        characterController.Move(verticalMovement * Time.deltaTime);       
    }


    public void Jump()
    {
        if(grounded)
        {
            verticalVelocity = jumpSpeed;

            AudioManager.instance.PlaySoundEffects(8);
        }
    }


    public void Shooting()
    {
       if(currentGunIndex == 0)
       {
            StartCoroutine(GunShot());
       }

        //Repeater shot in Update

       if (currentGunIndex == 2)
       {
            StartCoroutine(SniperShot());
       }

       if (currentGunIndex == 3)
       {
            RocketShot();
       }
    }


    public void Shoot()
    {
        if(activeGun.fireCounter <= 0)
        {
            RaycastHit hit;

            if (Physics.Raycast(camTransform.position, camTransform.forward, out hit, 50f))
            {
                if (Vector3.Distance(camTransform.position, hit.point) > 2f)
                {
                    firePoint.LookAt(hit.point);
                }
            }
            else
            {
                firePoint.LookAt(camTransform.position + (camTransform.forward * 30f));
            }

            shotCounter = timeBetweenShots;

            heatCounter += heatPerShot;

            if(heatCounter >= maxHeatValue)
            {
                heatCounter = maxHeatValue;

                isOverHeated = true;
            }
           
            //Instantiate(bullet, firePoint.position, firePoint.rotation);
            FireShot();
        }
    }




    public void FireShot()
    {
        if(activeGun.currentAmmo > 0)
        {
            activeGun.currentAmmo--;

            Instantiate(activeGun.bullet, firePoint.position, firePoint.rotation);

            activeGun.fireCounter = activeGun.fireRate;

            UIController.UIControllerScript.ammoText.text = "Ammo: " + activeGun.currentAmmo;

            muzzleFlash.SetActive(true);
        }
        else
        {
            AudioManager.instance.PlaySoundEffects(12);
        }
    }

    IEnumerator GunShot()
    {
        if (activeGun.fireCounter <= 0)
        {
            RaycastHit hit;

            if (Physics.Raycast(camTransform.position, camTransform.forward, out hit, 50f))
            {
                if (Vector3.Distance(camTransform.position, hit.point) > 2f)
                {
                    firePoint.LookAt(hit.point);
                }
            }
            else
            {
                firePoint.LookAt(camTransform.position + (camTransform.forward * 30f));
            }

            //Instantiate(bullet, firePoint.position, firePoint.rotation);          
            FireShot();       
        }

        shotButton.SetActive(false);

        yield return new WaitForSeconds(0.5f * Time.deltaTime);

        shotButton.SetActive(true);
    }

    IEnumerator SniperShot()
    {
        if (activeGun.fireCounter <= 0)
        {
            RaycastHit hit;

            if (Physics.Raycast(camTransform.position, camTransform.forward, out hit, 50f))
            {
                if (Vector3.Distance(camTransform.position, hit.point) > 2f)
                {
                    firePoint.LookAt(hit.point);
                }
            }
            else
            {
                firePoint.LookAt(camTransform.position + (camTransform.forward * 30f));
            }

            //Instantiate(bullet, firePoint.position, firePoint.rotation);
            FireShot();           
        }

        shotButton.SetActive(false);

        yield return new WaitForSeconds(0.5f * Time.deltaTime);

        shotButton.SetActive(true);
    }

    IEnumerator RocketShot()
    {
        if (activeGun.fireCounter <= 0)
        {
            RaycastHit hit;

            if (Physics.Raycast(camTransform.position, camTransform.forward, out hit, 50f))
            {
                if (Vector3.Distance(camTransform.position, hit.point) > 2f)
                {
                    firePoint.LookAt(hit.point);
                }
            }
            else
            {
                firePoint.LookAt(camTransform.position + (camTransform.forward * 30f));
            }

            //Instantiate(bullet, firePoint.position, firePoint.rotation);
            FireShot();
        }

        shotButton.SetActive(false);

        yield return new WaitForSeconds(2f * Time.deltaTime);

        shotButton.SetActive(true);
    }


    public void SwitchGun()
    {
        activeGun.gameObject.SetActive(false);

        if (currentGunIndex < allGuns.Count)            
        {
            currentGunIndex++;          
        }
        else
        {
            currentGunIndex = 0;           
        }

        activeGun = allGuns[currentGunIndex];
    
        activeGun.gameObject.SetActive(true);

        UIController.UIControllerScript.ammoText.text = "Ammo: " + activeGun.currentAmmo;

        firePoint.position = activeGun.firePoint.position;
    }



    public void ZoomInController()
    {
        zoomOnPanel.SetActive(false);
        zoomOutPanel.SetActive(true);

        CameraController.cameraScript.ZoomIn(activeGun.zoomAmount);
        PlayerPrefs.SetInt("zoomIsIn", 1);
    }

    public void ZoomOutController()
    {
        zoomOutPanel.SetActive(false);
        zoomOnPanel.SetActive(true);

        CameraController.cameraScript.ZoomOut();
        PlayerPrefs.SetInt("zoomIsIn", 0);
    }

    public void AddGun(string gunToAdd)
    {
        bool gunUnlocked = false;

        if(unlockableGuns.Count > 0)
        {
            for(int i = 0; i < unlockableGuns.Count; i++)
            {
                if(unlockableGuns[i].gunName == gunToAdd)
                {
                    gunUnlocked = true;

                    allGuns.Add(unlockableGuns[i]);

                    unlockableGuns.RemoveAt(i);

                    i = unlockableGuns.Count;
                }
            }
        }

        if(gunUnlocked)
        {
            currentGunIndex = allGuns.Count - 2;
            SwitchGun();
        }

    }


    public void Bounce(float bounceForce)
    {
        bounceAmount = bounceForce;
        bounce = true;
    }

    public void PointerDown()
    {
        isFiring = true;
    }

    public void PointerUp()
    {
        isFiring = false;
    }

}
