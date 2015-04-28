using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {
    //GUIskin
    public GUISkin MyGUISkin;
    public Texture2D Background, Logo;
    //or public Texture2D Logo;
    // set parameters for the Rect, width and height as a new Rectangle
    public Rect WindowRect = new Rect ((Screen.width / 2) - 100, Screen.height / 2, 200, 200);
    //MenuState, show first
    private string menuState;
    // public array string
    public string[] CreditsTextLines = new string [0];
    public string[] ControlTextLines = new string[0];
    private string main = "main";// main menu state
    private string options = "options";
    private string credits = "credits";
    private string controls = "controls";
    private string textToDisplay = "Credits \n";
    private string pointsToDisplay = "Controls \n";
    private float volume = 1.0f;
    void Start () 
    {   //the menuState is main
        menuState = main;
        // intially the value is 0 if the value is less than the length(number), 
        //set the value of CreditsText to x and increment the value for each string
        for (int x = 0; x < CreditsTextLines.Length; x++)
        {
            textToDisplay += CreditsTextLines[x] + "\n";
        }
        for (int x = 0; x < ControlTextLines.Length; x++)
        {
            pointsToDisplay += ControlTextLines[x] + "\n";
        }
        textToDisplay += "Press ESC to go back";
        pointsToDisplay += "Press ESC to go back";
	}

    private void OnGUI()
    {   // if Background is not null, meaning nothing there show this, JUST CHECKING
        if (Background != null)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Background);
        }
        // if Logo is not null, meaning nothing there show this, JUST CHECKING
        if (Logo != null)
        {
            GUI.DrawTexture(new Rect ((Screen.width/2 ) - 100, 30, 200, 200 ), Logo);
        }
        // anything below this is my control
        GUI.skin = MyGUISkin;
        
        // Check UI State
        // if menu is on main
        if (menuState == main)
        {
            WindowRect = GUI.Window(0, WindowRect, menuFunc, "Main Menu");
        }
        // if menu is on options
        if (menuState == options)
        {
            WindowRect = GUI.Window(1, WindowRect, optionsFunc, "Options");
        }
        // if menu is on credits
        if (menuState == credits)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), textToDisplay);
        }

        if (menuState == controls)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), pointsToDisplay);
        }
    }

    private void menuFunc(int id)
    {
        //buttons
        if (GUILayout.Button("Play Game"))
        {
            Application.LoadLevel(1);
        }

        if(GUILayout.Button("Options"))
        {
            menuState = options;
        }

        if (GUILayout.Button("Credits"))
        {
            menuState = credits;
        }

        if (GUILayout.Button("Quit Game"))
        {
            Application.Quit();
        }
    }
    private void optionsFunc(int id)
    {
        // won'twork if you swap levels
        GUILayout.Box("Volume");
        volume = GUILayout.HorizontalSlider(volume, 0.0f, 1.0f);// sets up volume slider
        AudioListener.volume = volume;// applies audio Listener to volume
        if (GUILayout.Button("Controls"))
        {
            menuState = controls;
        }
        if (GUILayout.Button("Back"))
        {   // if back is clicked send back to the main menu state
            menuState = main;
        }
    }
	// Update is called once per frame
	void Update () 
    {
        if (menuState == credits  && Input.GetKey(KeyCode.Escape))// if the menuState is in Credits and you press escape
        {
            menuState = main;// send back to main menu
        }

        if (menuState == controls && Input.GetKey(KeyCode.Escape))// if the menuState is in Credits and you press escape
        {
            menuState = options;// send back to main menu
        }
	
	}
}
