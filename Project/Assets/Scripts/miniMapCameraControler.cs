using UnityEngine;
using System.Collections;

public class miniMapCameraControler : MonoBehaviour {

    public GameObject player;
    public Renderer lvlRender;
    private Transform pt;
    void Start()
    {
        pt = player.GetComponent<Transform>();
    }

    void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Clamp(pt.position.x, lvlRender.bounds.min.x, lvlRender.bounds.max.x),
            GetComponent<Transform>().position.y, 
            GetComponent<Transform>().position.z);
    }
}
