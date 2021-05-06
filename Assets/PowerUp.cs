using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            PickUp(collider);
        }
    }

    void PickUp(Collider2D player)
    {
        
        PlayerMovement Speed = player.GetComponent<PlayerMovement>();
        Speed.movementSpeed += 5;

        Destroy(gameObject);

    }

}