using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomListing : MonoBehaviour {

    [SerializeField]
    private Text roomNameText;

    public string RoomName { get; private set; }

    public Text RoomNameText { get { return roomNameText; } }
    public bool updated { get; set; }

	void Start () {
        GameObject lobbyCanvasObj = MainCanvasManager.instance.lobbyCanvas.gameObject;
        if (!lobbyCanvasObj)
            return;
        LobbyCanvas lobbyCanvas = lobbyCanvasObj.GetComponent<LobbyCanvas>();
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() => lobbyCanvas.OnClickJoinRoom(roomNameText.text));
	}

    void OnDestroy(){
        Button button = GetComponent<Button>();
        button.onClick.RemoveAllListeners();
    }

    public void setRoomNameText(string text){
        RoomName = text;
        roomNameText.text = RoomName;
    }
	
	void Update () {
		
	}
}
