using UnityEngine;
using System.Collections;

public class player_Ball_Rotate : MonoBehaviour {

    public float speed;
    GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update ()
    {
        transform.RotateAround(player.transform.position, Vector3.forward, speed * Time.deltaTime);
    }
}
