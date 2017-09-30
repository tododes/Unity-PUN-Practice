using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : MonoBehaviour {

    public static PlayerNetwork instance;
    public string Name { get; private set; }

	void Awake () {
        Name = "Todo " + Random.Range(1000, 9999);
	}
}
