using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 50f;

    public Animator animator;

    public Rigidbody2D firePoint;

    public Camera cam;
    Vector2 mousePos;
    
    
    void Update()
    {
        // Hvis spilleren trykker på W sker koden nedenunder
        if (Input.GetKey(KeyCode.W)) {
            // Flytter spilleren op
            transform.position += new Vector3(0, movementSpeed) * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.A)) {
            
            transform.position += new Vector3(-movementSpeed, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.position += new Vector3(0, -movementSpeed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(movementSpeed, 0) * Time.deltaTime;
        
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


        }

        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
        animator.SetFloat("Speed", 1);
    }
    
    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - firePoint.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        firePoint.rotation = angle; 

        

    }
}
