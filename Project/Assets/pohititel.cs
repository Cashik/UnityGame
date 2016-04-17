using UnityEngine;
using System.Collections;

public class pohititel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("turret"))
        {
            Destroy(other.gameObject);
        }
        
    }
	// Update is called once per frame
	void Update () {
	
	}
}
