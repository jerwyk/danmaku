using UnityEngine;
using System.Collections;

public class enemy_Bullet_Movement : MonoBehaviour
{

    public float speed;
    public bool isRotating;
    public float rotation;
    public float startRotation;
    public float endRotation;
    public bool isChangeSpeed;
    public float changeRate;
    public float startChange;
    public float endChange;
    public Color32 color;

    Rigidbody2D rb2d;
    float fixedSpeed;
    float time=0;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        fixedSpeed = speed;
        GetComponent<SpriteRenderer>().color = color;
        InvokeRepeating("timer", 0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {

        rb2d.velocity = transform.up * fixedSpeed;

        if (isRotating && time > startRotation && time < endRotation)
        {
            rb2d.rotation += rotation;
        }

        if (isChangeSpeed && time > startChange && time < endChange)
        {
            fixedSpeed += changeRate;
            rb2d.velocity = transform.up * fixedSpeed;
        }

    }

    void timer()
    {
        time+=0.1f;
    }

}
