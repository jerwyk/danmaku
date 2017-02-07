using UnityEngine;
using System.Collections;

public class player_Ball : MonoBehaviour
{

    public int positionX,positionY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.localPosition = new Vector3(0.25f * positionX, 0.25f * positionY, 0);
        }
        else
        {
            transform.localPosition = new Vector3(0.6f * positionX, 0.6f * positionY, 0);
        }
    }
}
