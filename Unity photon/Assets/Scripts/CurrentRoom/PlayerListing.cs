using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListing : MonoBehaviour {

    public PhotonPlayer photonPlayer { get; private set; }

    [SerializeField]
    private Text _playerName;
    public Text PlayerName { get { return _playerName; } }

    public void ApplyPhotonPlayer(PhotonPlayer photonPlayer){
        this.photonPlayer = photonPlayer;
        PlayerName.text = photonPlayer.NickName;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
