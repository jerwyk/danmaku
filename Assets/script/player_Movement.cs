using UnityEngine;
using System.Collections;

public class player_Movement : MonoBehaviour
{

    public float speed;//speed of player
    public Transform field;//the area of the game
    public GameObject hitpoint;
    Animator anim;
    Rigidbody2D rb2d;
    float moveHorizontal, moveVertical;
    float minX, maxX, minY, maxY, x, y;
    float fixedSpeed;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        minX = field.position.x - field.localScale.x / 2 + 0.3f;
        maxX = field.position.x + field.localScale.x / 2 - 0.3f;
        minY = field.position.y - field.localScale.y / 2 + 0.4f;
        maxY = field.position.y + field.localScale.y / 2 - 0.4f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        moveHorizontal = Input.GetAxisRaw("Horizontal");//get input
        moveVertical = Input.GetAxisRaw("Vertical");
        x = rb2d.position.x;//current positio
        y = rb2d.position.y;
        fixedSpeed = speed;
        anim.SetFloat("moveH", moveHorizontal);//animation

        //speed fix
        if (moveHorizontal != 0 && moveVertical != 0)
        {
            fixedSpeed = (float)System.Math.Round(fixedSpeed / Mathf.Sqrt(2f), 2);
        }
        if (Input.GetKey(KeyCode.LeftShift))//slow speed mode
        {
            fixedSpeed = (float)System.Math.Round(fixedSpeed / 3, 2);
            hitpoint.SetActive(true);
        }
        else
        {
            hitpoint.SetActive(false);
        }


        // set boundarys
        if (x <= minX)//left
        {
            if (moveHorizontal <= 0)
                moveHorizontal = 0;
        }
        if (x >= maxX)//right
        {
            if (moveHorizontal >= 0)
                moveHorizontal = 0;
        }
        if (y <= minY)//down
        {
            if (moveVertical <= 0)
                moveVertical = 0;
        }
        if (y >= maxY)//up
        {
            if (moveVertical >= 0)
                moveVertical = 0;
        }
        //------------------------------

        rb2d.velocity = new Vector3(moveHorizontal, moveVertical) * fixedSpeed;//move

        //------------------------------

        if(global.playerLeft==0)
        {
            Destroy(this);
        }

    }

}
