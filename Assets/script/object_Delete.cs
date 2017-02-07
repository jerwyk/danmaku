using UnityEngine;
using System.Collections;

public class object_Delete : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullets" || other.gameObject.tag == "player_bullet")
        {
            if (other.gameObject.transform.parent != null)
            {
                Destroy(other.gameObject.transform.parent.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
    }
}
