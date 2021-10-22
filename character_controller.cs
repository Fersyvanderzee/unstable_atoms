using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_controller : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;

    void Start(){
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update(){
        var movement_horizontal = Input.GetAxis("Horizontal");
        var movement_vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(movement_horizontal, movement_vertical, 0).normalized * Time.deltaTime * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag != "Wall") {
            FindObjectOfType<game_manager>().EndGame();
        }

    }

}
