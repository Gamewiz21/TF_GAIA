using UnityEngine;
using System.Collections;

public class Gameoverwait : MonoBehaviour {

	public float delay = 5f;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (delay);
		Application.LoadLevel ("Main");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
