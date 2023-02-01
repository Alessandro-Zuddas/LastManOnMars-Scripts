using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointController : MonoBehaviour
{

    public string cpName;

    public static CheckpointController checkpointScript;


    private void Awake()
    {
        checkpointScript = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey(SceneManager.GetActiveScene().name + "_cp"))
        {
            if(PlayerPrefs.GetString(SceneManager.GetActiveScene().name + "_cp") == cpName)
            {
                PlayerController.playerController.transform.position = transform.position;
            }
        }
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "_cp", cpName);

            AudioManager.instance.PlaySoundEffects(1);
        }
    }

    public void CheckPointReset()
    {
        PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "_cp", "");
    }
}
