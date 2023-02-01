using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class BulletOnline : MonoBehaviourPunCallbacks
{
    public Camera cam;

    public GameObject bullet;

    public GameObject deathScreen;
    public Text deathText;

    public Slider healtSlider;
    public Text healtText;

    public int maxHealt = 100;
    private int currentHealt;

    public Gun[] allGuns;
    public int selectedGun;

    PhotonView view;

    public bool isOverHeated;
    public bool isFiring;
    public float heatCounter;
    public float coolRate;
    public float overHeatCoolRate;
    public float timeBetweenShots;
    public float heatPerShot;
    public float maxHeatValue;
    public float shotCounter;

    public GameObject shotButton;

    public GameObject overHeatMessage;
    public GameObject warningImage;

    public Slider heatControlSlider;
    public GameObject heatControlPanel;

    public Transform firePoint;
    public GameObject muzzleFlash;

    public GameObject zoomOnPanel;
    public GameObject zoomOutPanel;

    public int healAmount = 35;

    public static BulletOnline instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        view = FirstPersonControllerOnline.instance.view;

        currentHealt = maxHealt;

        healtSlider.maxValue = maxHealt;
        healtSlider.value = currentHealt;
        healtText.text = "Health: " + currentHealt + "/" + maxHealt;

        zoomOnPanel.SetActive(true);
        zoomOutPanel.SetActive(false);

        //SwitchGuns();
        photonView.RPC("SetGun", RpcTarget.All, selectedGun);
    }

    // Update is called once per frame
    void Update()
    {
        //Shot repeating gun con surriscaldamento
        if (selectedGun == 1)   
        {            

            if (!isOverHeated)
            {
                if (isFiring)
                {
                    RepeaterShoot();
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

            if (heatCounter < 0)
            {
                heatCounter = 0;
            }

            heatControlSlider.value = heatCounter;
        }

        if (isOverHeated && selectedGun == 1)
        {
             overHeatMessage.SetActive(true);
             warningImage.SetActive(true);
        }
        else
        {
             overHeatMessage.SetActive(false);
             warningImage.SetActive(false);
        }


        if (selectedGun == 1)
        {
            heatControlPanel.SetActive(true);
        }
        else
        {
            heatControlPanel.SetActive(false);
        }

      
    }

    public void Shooting()
    {
        if(selectedGun == 0)
        {
            StartCoroutine(GunShot());
        }

        if(selectedGun == 2)
        {
            StartCoroutine(SniperShot());
        }

    }


    IEnumerator GunShot()
    {
        if (allGuns[selectedGun].fireCounter <= 0)
        {

            Ray ray = cam.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
            ray.origin = cam.transform.position;

            FireShot();

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                //Debug.Log("We hit " + hit.collider.gameObject.name);
                if(hit.collider.gameObject.tag == "Player")
                {
                    Debug.Log("Hit " + hit.collider.gameObject.GetPhotonView().Owner.NickName); //FirstPersonControllerOnline.instance.photonView.Owner.NickName

                    hit.collider.gameObject.GetPhotonView().RPC("DealDamage", RpcTarget.All, gameObject.GetPhotonView().Owner.NickName, allGuns[selectedGun].shotDamage, PhotonNetwork.LocalPlayer.ActorNumber);
                }
            }
            //Instantiate(bullet, firePoint.position, firePoint.rotation);
        }

        shotButton.SetActive(false);

        yield return new WaitForSeconds(0.5f * Time.deltaTime);

        shotButton.SetActive(true);
    }

    public void RepeaterShoot()
    {
        if (allGuns[selectedGun].fireCounter <= 0)
        {

            Ray ray = cam.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
            ray.origin = cam.transform.position;

            FireShot();

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                //Debug.Log("We hit " + hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "Player")
                {
                    Debug.Log("Hit " + hit.collider.gameObject.GetPhotonView().Owner.NickName);

                    hit.collider.gameObject.GetPhotonView().RPC("DealDamage", RpcTarget.All, gameObject.GetPhotonView().Owner.NickName, allGuns[selectedGun].shotDamage, PhotonNetwork.LocalPlayer.ActorNumber);
                }
            }
            //Instantiate(bullet, firePoint.position, firePoint.rotation);

            shotCounter = timeBetweenShots;

            heatCounter += heatPerShot;

            if (heatCounter >= maxHeatValue)
            {
                heatCounter = maxHeatValue;

                isOverHeated = true;
            }
        }

    }


    IEnumerator SniperShot()
    {
        if (allGuns[selectedGun].fireCounter <= 0)
        {

            Ray ray = cam.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
            ray.origin = cam.transform.position;

            FireShot();

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log("We hit " + hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "Player")
                {
                    Debug.Log("Hit " + hit.collider.gameObject.GetPhotonView().Owner.NickName);

                    hit.collider.gameObject.GetPhotonView().RPC("DealDamage", RpcTarget.All, gameObject.GetPhotonView().Owner.NickName, allGuns[selectedGun].shotDamage, PhotonNetwork.LocalPlayer.ActorNumber);
                }
            }
        }

        shotButton.SetActive(false);

        yield return new WaitForSeconds(0.5f * Time.deltaTime);

        shotButton.SetActive(true);
    }

    public void FireShot()
    {
        if (allGuns[selectedGun].currentAmmo > 0)
        {
            allGuns[selectedGun].currentAmmo--;

            PhotonNetwork.Instantiate(allGuns[selectedGun].bulletOnline.name, allGuns[selectedGun].firePoint.position, allGuns[selectedGun].firePoint.rotation);

            allGuns[selectedGun].fireCounter = allGuns[selectedGun].fireRate;

            UIController.UIControllerScript.ammoText.text = "Ammo: " + allGuns[selectedGun].currentAmmo;

            muzzleFlash.SetActive(true);
        }
        else
        {
           if(view.IsMine)
           {
                AudioManager.instance.PlaySoundEffects(12);
           }
        }
    }

    public void PointerDown()
    {
       isFiring = true;
    }

    public void PointerUp()
    {
       isFiring = false;
    }
    
    public void ZoomOn()
    {
        zoomOnPanel.SetActive(false);
        zoomOutPanel.SetActive(true);

        CameraController.cameraScript.ZoomIn(allGuns[selectedGun].zoomAmount);
    }

    public void ZoomOff()
    {
        zoomOutPanel.SetActive(false);
        zoomOnPanel.SetActive(true);

        CameraController.cameraScript.ZoomOut();
    }

    [PunRPC]
    public void DealDamage(string damager, int damageAmount, int actor)
    {
        //Prova
        Debug.Log("Chiamato il DealDamage");
        TakeDamage(damager, damageAmount, actor);
    }

    public void TakeDamage(string damager, int damageAmount, int actor)
    {
        Debug.Log("Dentro al Take damage");

        if (view.IsMine)
        {
            //Prova
            Debug.Log("Dentro al Take damage isMine");
            AudioManager.instance.PlaySoundEffects(7);

            currentHealt -= damageAmount;

            UIController.UIControllerScript.ShowDamage();

            if (currentHealt <= 0)
            {
                healtSlider.value = currentHealt;
                healtText.text = "Health: " + currentHealt + "/" + maxHealt;

                currentHealt = 0;

                PlayerSpawner.instance.Die(damager);

                MatchManager.instance.UpdateStatsSend(actor, 0, 1);
            }

            healtSlider.value = currentHealt;
            healtText.text = "Health: " + currentHealt + "/" + maxHealt;
        }
    }

    public void Switch()
    {
        selectedGun++;

        if(selectedGun >= allGuns.Length)
        {
            selectedGun = 0;
        }
        
        if(selectedGun < 0)
        {
            selectedGun = allGuns.Length - 1;
        }

        //SwitchGuns();
        photonView.RPC("SetGun", RpcTarget.All, selectedGun);
    }

    public void SwitchGuns()
    {
        foreach(Gun gun in allGuns)
        {
            gun.gameObject.SetActive(false);
        }

        allGuns[selectedGun].gameObject.SetActive(true);
    }


    [PunRPC]
    public void SetGun(int gunToSwitchTo)
    {
        if(gunToSwitchTo < allGuns.Length)
        {
            selectedGun = gunToSwitchTo;
            SwitchGuns();
        }
    }
/*
    [PunRPC]
    public void GetAmmo()
    {
        if(view.IsMine)
        {
            Debug.Log("Dentro GetAmmo");

            allGuns[selectedGun].currentAmmo += Gun.instance.pickupAmount;

            UIController.UIControllerScript.ammoText.text = "Ammo: " + allGuns[selectedGun].currentAmmo;
        }
    }

    public void CallGetAmmo()
    {
        photonView.RPC("GetAmmo", RpcTarget.All, gameObject.GetPhotonView().Owner.NickName, PhotonNetwork.LocalPlayer.ActorNumber);

        Debug.Log("Chiamato GetAmmo()");
    }

    [PunRPC]
    public void HealPlayer(int healAmount)
    {
       if(view.IsMine)
       {
            Debug.Log("Dentro HealPlayer");

            currentHealt += healAmount;

            if (currentHealt >= maxHealt)
            {
                currentHealt = maxHealt;
            }

            healtSlider.value = currentHealt;
            healtText.text = "Health: " + currentHealt + "/" + maxHealt;
       }
    }

    public void CallHealPlayer()
    {
        photonView.RPC("HealPlayer", RpcTarget.All, gameObject.GetPhotonView().Owner.NickName, healAmount, PhotonNetwork.LocalPlayer.ActorNumber);

        Debug.Log("Chiamato HealPlayer()");
    }
*/
}
