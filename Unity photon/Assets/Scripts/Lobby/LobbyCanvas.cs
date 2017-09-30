using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyCanvas : MonoBehaviour {

    [SerializeField]
    private RoomLayoutGroup _roomLayoutGroup;

    public RoomLayoutGroup roomLayoutGroup { get { return _roomLayoutGroup; } }

    public void OnClickJoinRoom(string roomName){
        if (PhotonNetwork.JoinRoom(roomName)){

        }
        else{
            Debug.Log("Join room failed");
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
