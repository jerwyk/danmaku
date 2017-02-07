using UnityEngine;
using System.Collections;

public class hitpoint : MonoBehaviour
{

    public float speed;
    GameObject player;

    // Use this for initialization
    void Start()
    {

        //rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //rb2d.angularVelocity = speed;
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullets")
        {
            global.playerLeft--;
            print(other.gameObject.tag);
            print("player" + global.playerLeft);
        }
    }

}
