using UnityEngine;
using System.Collections;

public class boss_Danmaku : MonoBehaviour
{

    public GameObject bullet;
    public float startHealth;
    GameObject player;

    // Use this for initialization
    void Start()
    {      
        player = GameObject.FindGameObjectWithTag("Player");
        global.bossHealth = 1000;
        Invoke("spell_1", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    float repeatTime = 1;

    void spell_1()
    {
        //danmaku.strait_Line(bullet, gameObject.transform.position, , 10);
        for (int i = -1; i < 2; i += 2)
        {
            enemy_Bullet_Movement move = bullet.GetComponent<enemy_Bullet_Movement>();
            move.isChangeSpeed = true;
            move.changeRate = -(1.2f / 200f);
            move.startChange = 0.3f;
            move.endChange = 2f;
            move.endRotation = 2.5f;
            move.color = new Color32(144, 255, 237,255);
            danmaku.on_Arc(bullet, transform.position, 60, 360, Random.Range(0, 360), 3, 0.2f * i, 0.3f);
        }

        repeatTime -= repeatTime > 0.6f ? 0.02f : 0f;

        if (global.bossHealth > 0)
        {
            Invoke("spell_1", repeatTime);
        }

    }

}
