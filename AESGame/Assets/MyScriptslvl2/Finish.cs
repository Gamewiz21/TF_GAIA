using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	public Texture2D Background;
	
	public float delay = 3f;
	
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (delay);
		Application.LoadLevel ("End");
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void OnGUI () {
		// if Background is not null, meaning nothing there show this, JUST CHECKING
		if (Background != null)
		{
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Background);
		}
		
	}
}
