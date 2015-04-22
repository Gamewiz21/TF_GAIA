using UnityEngine;
using System.Collections;

public class StartRespond : MonoBehaviour {

    void OnEnabled()
    {
        StartEvent.GameStart += GameStart;
    }
    void OnDisabled()
    {
        StartEvent.GameStart -= GameStart;
    }

    void GameStart()
    {
        Application.LoadLevel(1);
    }
}
