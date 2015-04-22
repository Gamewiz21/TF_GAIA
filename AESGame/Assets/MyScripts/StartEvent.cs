using UnityEngine;
using System.Collections;

public class StartEvent : MonoBehaviour {

    public delegate void OnStartUp();

    public static event OnStartUp GameStart;


    void OnGUI()
    {
        if (GUI.Button(new Rect(5, 5, 150, 40), "Start Game"))
        {


            if (GameStart != null)
            {
               GameStart();
            }
        }
    }
}
