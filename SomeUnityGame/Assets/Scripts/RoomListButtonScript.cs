using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Realtime;
using Photon.Pun;

public class RoomListButtonScript : MonoBehaviour
{
    [SerializeField] private TMP_Text roomName;
    private RoomInfo _info;

    public void SetUP(RoomInfo roomInfo)
    {
        _info = roomInfo;
        roomName.text = _info.Name;
    }

    public void OnClick()
    {
        Launcher.instance.JoinRoom(_info);
    }
}
