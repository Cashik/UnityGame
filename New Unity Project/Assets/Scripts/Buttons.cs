using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

    public int a;

    void Start()
    {
        a = 2;
    }

    void Update () {
      
    }

    void OnMouseDown()
    {
        a = 4;
        switch (gameObject.name)
        {
            case "Exit":
                Application.OpenURL("http://google.com");
                break;
        }
    }

    void OnClick()
    {
        a = 5;
    }
}
