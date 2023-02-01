using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Realtime;


public class Launcher : MonoBehaviourPunCallbacks
{
    public GameObject loadingScreen;
    public Text loadingtext;
    public GameObject loadingImage;

    public GameObject menuButton;
    public GameObject settingsButton;
    public GameObject leaveButton;
    public GameObject createButton;
    public GameObject findButton;
    public GameObject errorScreen;
    public GameObject findRoomScreen;
    public Text errorText;

    public GameObject createRoomScreen;
    public InputField roomNameInput;

    public GameObject roomScreen;
    public Text roomNameText, playerNameLabel;

    private List<Text> allPlayersNames = new List<Text>();


    public AudioClip sfxClick;

    public RoomButton theRoomButton;
    private List<RoomButton> allRoomButtons = new List<RoomButton>();

    public GameObject nameInputScreen;
    public InputField nameInput;
    private bool hasSetName;

    public string levelToPlay;

    public GameObject startButton;
    public bool isOnline;

    public string[] allMaps;
    public bool changeMapBetweenRounds = true;

    public static Launcher instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        isOnline = true;

        CloseMenus();
        loadingScreen.SetActive(true);
        loadingtext.text = "CONNECTING TO THE SERVER...";

        if(!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloseMenus()
    {
        loadingScreen.SetActive(false);

        menuButton.SetActive(false);
        createButton.SetActive(false);
        settingsButton.SetActive(false);
        leaveButton.SetActive(false);
        findButton.SetActive(false);

        createRoomScreen.SetActive(false);
        roomScreen.SetActive(false);
        errorScreen.SetActive(false);
        findRoomScreen.SetActive(false);
        nameInputScreen.SetActive(false);
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();

        PhotonNetwork.AutomaticallySyncScene = true;

        loadingtext.text = "Joining Lobby...";
    }

    public override void OnJoinedLobby()
    {
        CloseMenus();

        menuButton.SetActive(true);
        createButton.SetActive(true);
        settingsButton.SetActive(true);
        leaveButton.SetActive(true);
        findButton.SetActive(true);

        PhotonNetwork.NickName = Random.Range(0, 1000).ToString();

        if(!hasSetName)
        {
            CloseMenus();
            nameInputScreen.SetActive(true);

            if(PlayerPrefs.HasKey("NickName"))
            {
                PhotonNetwork.NickName = PlayerPrefs.GetString("NickName");

                CloseMenus();
                menuButton.SetActive(true);
                createButton.SetActive(true);
                settingsButton.SetActive(true);
                leaveButton.SetActive(true);
                findButton.SetActive(true);
            }
        }
        else
        {
            PhotonNetwork.NickName = PlayerPrefs.GetString("NickName");

            CloseMenus();
            menuButton.SetActive(true);
            createButton.SetActive(true);
            settingsButton.SetActive(true);
            leaveButton.SetActive(true);
            findButton.SetActive(true);
        }
    }

    public void OpenCreateRoom()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        createRoomScreen.SetActive(true);
    }

    public void BackButtonRoom()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        createRoomScreen.SetActive(false);
    }

    public void CreateRoom()
    {
        if(!string.IsNullOrEmpty(roomNameInput.text))
        {
            GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

            RoomOptions options = new RoomOptions();
            options.MaxPlayers = 8;

            PhotonNetwork.CreateRoom(roomNameInput.text, options);

            CloseMenus();
            loadingtext.text = "Creating Room...";
            loadingScreen.SetActive(true);
        }
    }

    public override void OnJoinedRoom()
    {
        CloseMenus();
        roomScreen.SetActive(true);

        roomNameText.text = PhotonNetwork.CurrentRoom.Name;

        ListAllPlayers();

        if(PhotonNetwork.IsMasterClient)
        {
            startButton.SetActive(true);
        }
        else
        {
            startButton.SetActive(false);
        }
    }

    private void ListAllPlayers()
    {
        foreach(Text player in allPlayersNames)
        {
            Destroy(player.gameObject);
        }

        allPlayersNames.Clear();

        Player[] players = PhotonNetwork.PlayerList;

        for(int i = 0; i < players.Length; i++)
        {
            Text newPlayerLable = Instantiate(playerNameLabel, playerNameLabel.transform.parent);
            newPlayerLable.text = players[i].NickName;
            newPlayerLable.gameObject.SetActive(true);

            allPlayersNames.Add(newPlayerLable);
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Text newPlayerLable = Instantiate(playerNameLabel, playerNameLabel.transform.parent);
        newPlayerLable.text = newPlayer.NickName;
        newPlayerLable.gameObject.SetActive(true);

        allPlayersNames.Add(newPlayerLable);
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        ListAllPlayers(); 
    }

    public void BackButtonJoinedRoom()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        PhotonNetwork.LeaveRoom();

        CloseMenus();
        loadingtext.text = "Leaving Room...";
        loadingScreen.SetActive(true);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        errorText.text = "Failed for: " + message;

        CloseMenus();
        errorScreen.SetActive(true);
    }

    public void CloseErrorScreen()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        CloseMenus();

        menuButton.SetActive(true);
        createButton.SetActive(true);
        settingsButton.SetActive(true);
        leaveButton.SetActive(true);
        findButton.SetActive(true);
    }

    public override void OnLeftRoom()
    {
        CloseMenus();

        menuButton.SetActive(true);
        createButton.SetActive(true);
        settingsButton.SetActive(true);
        leaveButton.SetActive(true);
        findButton.SetActive(true);
    }

    public void OpenFindRoom()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        CloseMenus();

        findRoomScreen.SetActive(true);
    }

    public void BackButtonFindRoom()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        CloseMenus();

        menuButton.SetActive(true);
        createButton.SetActive(true);
        settingsButton.SetActive(true);
        leaveButton.SetActive(true);
        findButton.SetActive(true);
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach(RoomButton rb in allRoomButtons)
        {
            Destroy(rb.gameObject);
        }

        allRoomButtons.Clear();

        theRoomButton.gameObject.SetActive(false);

        for(int i = 0; i < roomList.Count; i++)
        {
            if(roomList[i].PlayerCount != roomList[i].MaxPlayers && !roomList[i].RemovedFromList)
            {
                RoomButton newButton = Instantiate(theRoomButton, theRoomButton.transform.parent);
                newButton.SetButtonDetails(roomList[i]);
                newButton.gameObject.SetActive(true);

                allRoomButtons.Add(newButton);
            }
        }
    }

    public void JoinRoom(RoomInfo inputInfo)
    {
        PhotonNetwork.JoinRoom(inputInfo.Name);

        CloseMenus();
        loadingtext.text = "Joining Room...";
        loadingScreen.SetActive(true);
    }

    public void RefreshCor()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        StartCoroutine(Refresh());
    }

    IEnumerator Refresh()
    {
        yield return null;
    }

    public void SetNickName()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        if (!string.IsNullOrEmpty(nameInput.text))
        {
            PhotonNetwork.NickName = nameInput.text;

            PlayerPrefs.SetString("NickName", nameInput.text);

            CloseMenus();

            menuButton.SetActive(true);
            createButton.SetActive(true);
            settingsButton.SetActive(true);
            leaveButton.SetActive(true);
            findButton.SetActive(true);

            hasSetName = true;
        }
    }

    public void StartGame()
    {
        GetComponent<AudioSource>().PlayOneShot(sfxClick, 1f);

        // PhotonNetwork.LoadLevel(levelToPlay);

        PhotonNetwork.LoadLevel(allMaps[Random.Range(0, allMaps.Length)]);

        StartCoroutine(DiasbleStartButton());
    }

    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        if (PhotonNetwork.IsMasterClient)
        {
            startButton.SetActive(true);
        }
        else
        {
            startButton.SetActive(false);
        }
    }

    IEnumerator DiasbleStartButton()
    {
        startButton.SetActive(false);

        yield return new WaitForSeconds(5f);

        startButton.SetActive(true);
    }
}
