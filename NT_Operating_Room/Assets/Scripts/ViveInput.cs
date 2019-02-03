using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class ViveInput : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        if (SteamVR_Input._default.inActions.Teleport.GetStateDown(SteamVR_Input_Sources.Any)) {
            print("Pressed tracked pad down");
        }
	}
}
