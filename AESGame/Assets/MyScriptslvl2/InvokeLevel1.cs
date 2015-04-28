using UnityEngine;
using System.Collections;

public class InvokeLevel1 : MonoBehaviour {

	public Texture2D Background;
	
	
	public float delay = 3f;
	
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (delay);
		Application.LoadLevel (4);
		
	}
	
	// Update is called once per frame
	private void OnGUI () {
		// if Background is not null, meaning nothing there show this, JUST CHECKING
		if (Background != null)
		{
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Background);
		}
		
	}
}
