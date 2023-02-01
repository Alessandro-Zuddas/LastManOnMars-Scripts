using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class PlayerSpawner : MonoBehaviour
{
    public GameObject cam;

    public static PlayerSpawner instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject playerPrefab;
    private GameObject player;

    public GameObject deathEffect;

    public float respawnTime = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        cam.SetActive(false);

        if (PhotonNetwork.IsConnected)
        {
            SpawnPlayer();
        }
    }

    public void SpawnPlayer()
    {
        cam.SetActive(false);

        Transform spawnPoint = SpawnManager.instance.GetSpawnPoint();

        player = PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position, spawnPoint.rotation);

        player.transform.Find("Main Camera").gameObject.SetActive(true);

        player.transform.Find("Canvas").gameObject.SetActive(true);

        player.transform.Find("GunHolder").gameObject.SetActive(true);
    }

    public void Die(string damager)
    {
        MatchManager.instance.deathText.text = "You were killed by: " + damager;

        //PhotonNetwork.Destroy(player);

        //SpawnPlayer();

        MatchManager.instance.UpdateStatsSend(PhotonNetwork.LocalPlayer.ActorNumber, 1, 1);

        if(player != null)
        {
            StartCoroutine(DieCoroutine());
        }
    }

    public IEnumerator DieCoroutine()
    {
        PhotonNetwork.Instantiate(deathEffect.name, player.transform.position, Quaternion.identity);

        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);

        PhotonNetwork.Destroy(player);

        player = null;

        cam.SetActive(true);

        MatchManager.instance.deathScreen.SetActive(true);

        yield return new WaitForSeconds(respawnTime);

        MatchManager.instance.deathScreen.SetActive(false);

        if(MatchManager.instance.state == MatchManager.GameState.Playing && player == null)
        {
            SpawnPlayer();
        }
    }
}
