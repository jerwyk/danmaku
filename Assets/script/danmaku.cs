using UnityEngine;
using System.Collections;

public class danmaku : MonoBehaviour
{

    public float angle, speed;


    public static void strait_Line(GameObject bullet, Vector3 position, float angle, float speed)//,float distance)
    {

        bullet.GetComponent<player_Bullet_Movement>().speed = speed;
        Instantiate(bullet, position, Quaternion.Euler(new Vector3(0, 0, angle)));

    }
    ///<summary>
    ///creats a circular danmaku with num bullets on its circumfrunce of a angle degrees arc, pointing at direction and moves at speed
    ///</summary>
    public static void on_Arc(GameObject bullet, Vector3 center, int num, float angle, float direction, float speed, float rotation = 0, float startRotation = 0)
    {

        float angleBetween = angle / (float)num;
        float startAngle = direction - angle / 2;
        enemy_Bullet_Movement move = bullet.GetComponent<enemy_Bullet_Movement>();
        move.speed = speed;

        for (int i = 0; i < num; i++)
        {
            
            if (rotation != 0)
            {
                move.isRotating = true;
                move.rotation = rotation;
                move.startRotation = startRotation;
            }

            Instantiate(bullet, center, Quaternion.Euler(new Vector3(0, 0, startAngle + angleBetween * i)));
        }
    }

}
