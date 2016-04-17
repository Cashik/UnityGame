using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

    // load game lvl
    public void Play()
    {
        Application.LoadLevel("Game");
    }
    public void Goals()
    {

        Application.LoadLevel("Goals");
    }
    public void Store()
    {

        Application.LoadLevel("Store");
    }
    public void Skills()
    {

        Application.LoadLevel("Skills");
    }
    public void Back()
    {

        Application.LoadLevel("MainMenu");
    }
}
