using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

    public Texture2D Background;// Background texture

    public float delay = 3f;// delay time
	
	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(delay);// hold frame based on the number of seconds on delay
        Application.LoadLevel("End");// go to scene afterward
		
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
