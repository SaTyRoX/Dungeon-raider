using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulllet : MonoBehaviour
{
    


   void OnCollisionEnter2D(Collision2D collision)
   {
        if (collision.gameObject.tag == "Barrel")
        {
            Destroy(collision.gameObject);
        }
        
        Destroy(gameObject);
      }
   }
