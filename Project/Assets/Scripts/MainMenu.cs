using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {


    public void Play()
    {
        Application.LoadLevel("StartMenu");
    }
    
    public void About()
    {
        //TODO about layer
    }
    public void Options()
    {
        //TODO options menu
    }
    // Exit from App
	public void Exit () {
        
        Application.Quit();
	}
	
}
