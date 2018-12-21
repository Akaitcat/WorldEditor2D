using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEUIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        WEMainMenu._Instance.AddMenuItem(new OpenFile());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
