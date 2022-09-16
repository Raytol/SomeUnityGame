using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;
using Photon.Realtime;

public class Launcher : MonoBehaviourPunCallbacks
{
    public static Launcher instance;

    [SerializeField] private GameObject LoadingScreen;
    [SerializeField] private GameObject LobbyMenu;
    [SerializeField] private GameObject ErrorScreen;
    [SerializeField] private TMP_InputField LobbyName;
    [SerializeField] private TMP_Text RoomNameText;
    [SerializeField] private GameObject RoomStandart;
    [SerializeField] private GameObject AvailableRooms;
    [SerializeField] private Transform RoomList;
    [SerializeField] private GameObject RoomButtonPrefab;
    [SerializeField] private Transform playerlist;
    [SerializeField] private GameObject PlayerNamePrefab;

    public void Start()
    {
        instance = this;
        Debug.Log("Подключение к Мастер серверу");
        PhotonNetwork.ConnectUsingSettings();
        LoadingScreen.SetActive(true); ;
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Присоединились к Мастер серверу");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        LoadingScreen.SetActive(false);
        Debug.Log("Присоединились к Лобби");
        LobbyMenu.SetActive(true);
        PhotonNetwork.NickName = "Player " + Random.Range(0, 100);
    }

    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(LobbyName.text))
        {
            return;
        }
        PhotonNetwork.CreateRoom(LobbyName.text);
        LoadingScreen.SetActive(true);
    }

    public override void OnJoinedRoom()
    {
        AvailableRooms.SetActive(false);
        LoadingScreen.SetActive(false);
        RoomStandart.SetActive(true);
        RoomNameText.text = PhotonNetwork.CurrentRoom.Name;

        Player[] players = PhotonNetwork.PlayerList;

        for (int i = 0; i < playerlist.childCount; i++)
        { 
            Destroy(playerlist.GetChild(i).gameObject);
        }

        for (int i = 0; i < players.Length; i++)
        {
            Instantiate(PlayerNamePrefab, playerlist).GetComponent<PlayerListItem>().SetUp(players[i]);
        }
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        LoadingScreen.SetActive(false);
        ErrorScreen.SetActive(true);
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        RoomStandart.SetActive(false);
        LoadingScreen.SetActive(true);
    }

    public override void OnLeftRoom()
    {
        LoadingScreen.SetActive(false);
        LobbyMenu.SetActive(true);
    }

    public void BackInMenu()
    {
        AvailableRooms.SetActive(false);
        LobbyMenu.SetActive(true);
    }

    public void AvailableRoomsButton()
    {
        LobbyMenu.SetActive(false);
        AvailableRooms.SetActive(true);
    }

    public void JoinRoom(RoomInfo infa)
    {
        PhotonNetwork.JoinRoom(infa.Name);
        LoadingScreen.SetActive(true);
        
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        for (int i = 0; i < RoomList.childCount; i++)
        {
            Destroy(RoomList.GetChild(i).gameObject);
        }
        for (int i = 0; i < roomList.Count; i++)
        {
            if (roomList[i].RemovedFromList)
                continue;
            Instantiate(RoomButtonPrefab, RoomList).GetComponent<RoomListButtonScript>().SetUP(roomList[i]);
        }
    }

    public override void OnPlayerEnteredRoom(Player player)
    {
        Instantiate(PlayerNamePrefab, playerlist).GetComponent<PlayerListItem>().SetUp(player);
    }
}
