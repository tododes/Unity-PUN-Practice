using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyNetwork : MonoBehaviour {

	void Start () {
        Debug.Log("Connecting to the server");
        PhotonNetwork.ConnectUsingSettings("0.0.0");
	}

    private void OnConnectedToMaster()
    {
        Debug.Log("Connected to master");
        PhotonNetwork.playerName = "Tododes3";
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    private void OnJoinedLobby(){
        Debug.Log("Joined lobby");
        if(!PhotonNetwork.inRoom)
            MainCanvasManager.instance.lobbyCanvas.transform.SetAsLastSibling();
    }
}
