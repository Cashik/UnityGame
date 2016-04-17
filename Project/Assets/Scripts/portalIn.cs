using UnityEngine;
using System.Collections;

public class portalIn : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        //ParticleSystem ps = GetComponent<ParticleSystem>();
        //ps.startColor = new Vector4(0f, 0f, 0.5f, 1f);
        Debug.Log("SUKA_RABOTAET_AHUENNO");
    }

    void OnCollisionEnter()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        ps.startColor = new Vector4(0f, 0f, 0.5f, 1f);
        Debug.Log("isEnter");
    }

    void IsTriggerExit()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        ps.startColor = new Color(100,1,255,255);
    }
}
