using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviour {

    [SerializeField]
    private Text roomName;
    public Text RoomName { get { return roomName; } }

	void Start () {
		
	}

	void Update () {
		
	}

    public void OnClick_CreateRoom(){
        RoomOptions roomOptions = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = 4 };
        if (PhotonNetwork.CreateRoom(RoomName.text, roomOptions, TypedLobby.Default)){
            Debug.Log("Create room successfully sent");
        }
        else{
            Debug.Log("Create room failed to send");
        }
    }

    void OnPhotonCreateRoomFailed(object[] codeAndMessage){
        Debug.Log("Create room failed : " + codeAndMessage[1]);
    }

    void OnCreatedRoom(){
        Debug.Log("Room created successfully");
    }
}
