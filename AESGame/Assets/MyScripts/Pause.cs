using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
    bool CanPause;// bool can Pause
    
	void Start () {
     CanPause = true;// at start you can pause
 }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))// when Backspace is pressed
        {
            if (CanPause)
            {
                //Debug.Log("pause");
                Time.timeScale = 0;// scene time equals 0
                CanPause = false;
                
            }
            else
            {
                Time.timeScale = 1;
                CanPause = true;
            }
        }
    }
}
