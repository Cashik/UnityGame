using UnityEngine;
using System.Collections;


public class CameraController : MonoBehaviour {

    public GameObject player;
    public Renderer lvlRender;
    private Camera cam;

    //public Vector2 touchString ;

    private Transform pt;

    void Start ()
    {
        pt = player.GetComponent<Transform>();
        cam = gameObject.GetComponent<Camera>();
    }
    
    void LateUpdate ()
    {
        // camera sizes
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;

        transform.position = new Vector3
        (
            Mathf.Clamp(pt.position.x, lvlRender.bounds.min.x + width / 2f+0.1f, lvlRender.bounds.max.x - width / 2f),
            Mathf.Clamp(pt.position.y, lvlRender.bounds.min.y + height / 2f, lvlRender.bounds.max.y - height / 2f),
            transform.position.z
        );

    }

    void OnGUI()
    {
        if (Input.touchCount > 0)
        {
            //touchString = Input.GetTouch(0).position;
            /*if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                touchString = "Phase: Touch began.";
            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved &&
                Input.GetTouch(0).deltaPosition.x > 2 &&
                Input.GetTouch(0).deltaPosition.y > 2)
            {
                touchString = "Phase: Touch Ended";
            }*/

        }
           
        
    }
}
