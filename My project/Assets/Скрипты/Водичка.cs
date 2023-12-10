using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Водичка : MonoBehaviour
{
    public GameObject respawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = respawnPoint.gameObject.transform.position;
        }
    }

}
