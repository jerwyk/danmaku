using UnityEngine;
using System.Collections;

public class player_Fire : MonoBehaviour
{

    public float fireRate;
    public GameObject bullet;
    float nextFire;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //shooting
        if (Input.GetKey(KeyCode.Z) && Time.time >= nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 0.2f), Quaternion.identity);
        }
    }
}
