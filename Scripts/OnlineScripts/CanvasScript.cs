using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public GameObject endScreen; 
    public Text lastManText;

    public Text killsText, deathsText;

    public GameObject leaderboard;
    public LeaderboardPlayer leaderboardPlayerDisplay;

    public GameObject pausePanel;

    public GameObject deathScreen;
    public Text deathText;

    public Text timerText;

    public static CanvasScript instance;

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
        
    }
}
