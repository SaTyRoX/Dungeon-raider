using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour{
    public Transform player;
    private GameObject Player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    float lockPos = 0;
    public PointManager pm;
   
    public int NextScene;

    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        transform.rotation = Quaternion.Euler (lockPos, lockPos, lockPos);
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void FixedUpdate() {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    
    
    void OnCollisionEnter2D(Collision2D coll)
   {
     if (coll.gameObject.CompareTag("Player"))
     {
          Destroy(Player);
        SceneManager.LoadScene(NextScene);
         
     }
     
     if (coll.gameObject.CompareTag("Bullet"))
     {
         
          Destroy(coll.gameObject);
          Destroy(gameObject);
          pm.AddPoint(1);
         
     }
}


    
}
