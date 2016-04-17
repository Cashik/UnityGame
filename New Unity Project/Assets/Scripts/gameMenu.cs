using UnityEngine;
using System.Collections;

public class gameMenu : MonoBehaviour {


    
    public void restartLvl()
    {

        Application.LoadLevel("game");
    }

    public void changeShipEngienPower()
    {
        float a = GameObject.Find("mineEngienPowerSlider").GetComponent<UnityEngine.UI.Slider>().value;
        
    }
}
