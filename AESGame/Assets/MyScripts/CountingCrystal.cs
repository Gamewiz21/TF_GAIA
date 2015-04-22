using UnityEngine;
using System.Collections;

public class CountingCrystal : MonoBehaviour {
	// numerical value of crystal
	public int crystalCount;
	public GUIStyle HUD;
	// Use this for initialization
	void Start () {
		crystalCount = 0;// at start the value will be zero
	
	}
	
	// Update is called once per frame
	void OnGUI () {// the HUd will display the value of crystal
		GUI.Label (new Rect (10, 10, 200, 100), "Crystals: " + crystalCount,HUD);
	
	}
}
