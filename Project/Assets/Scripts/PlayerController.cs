using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour {
    public float mineEngientMaxPower = 5f;
    public float sideEngientMaxPower = 90f;
    public float mineEngientPower = 0;
    public float sideEngientPower = 0;

    //public float angle = 1;
    public Boundary boundary;
    public float moveHorizontal, moveVertical;
    void FixedUpdate()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        //  устанавливаем силу двигателя
        if (moveVertical != 0)
        {
            if (moveVertical > 0) mineEngientPower += (mineEngientMaxPower)*Time.deltaTime;
            else mineEngientPower -= (mineEngientMaxPower) * Time.deltaTime;
        }
        mineEngientPower = Mathf.Clamp(mineEngientPower, 0, mineEngientMaxPower);

        // создаем тяговую силу
        Vector2 speedUp = new Vector2(0,1);
        speedUp *= mineEngientPower;
        float angleInRad = (rb.rotation * Mathf.PI) / 180;
        speedUp.Set(
            speedUp.x * Mathf.Cos(angleInRad) - speedUp.y * Mathf.Sin(angleInRad),
            speedUp.y * Mathf.Cos(angleInRad) + speedUp.x * Mathf.Sin(angleInRad)
            );

        // изменяем векторы сил, создающих дальнейшее передвежения(перемещает физ движок)
        rb.angularVelocity -= moveHorizontal*sideEngientMaxPower*Time.deltaTime;
        rb.velocity += speedUp * Time.deltaTime;


        // регулируем количество выпускаемого вещества с двигателя
        UnityEngine.ParticleSystem.EmissionModule ems = GetComponentInChildren<ParticleSystem>().emission;
        ems.rate = new ParticleSystem.MinMaxCurve(100f * (mineEngientPower / mineEngientMaxPower));

        /*rb.position = new Vector2
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax)
        );*/
    }


    public void chaingEngienSpeed()
    {
       mineEngientPower = GameObject.Find("mineEngienPowerSlider").GetComponent<UnityEngine.UI.Slider>().value*mineEngientMaxPower;
    }

    void OnTriggerEnter(Collider other)
    {
        //ParticleSystem ps = GetComponent<ParticleSystem>();
        //ps.startColor = new Vector4(0f, 0f, 0.5f, 1f);
        Debug.Log("isEnter");
    }
    
}
