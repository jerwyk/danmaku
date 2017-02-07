using UnityEngine;
using System.Collections;

public class enemy_hitbox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player_bullets")
        {
            global.bossHealth -= 1;
            print("boss" + global.bossHealth);
        }
    }

}
