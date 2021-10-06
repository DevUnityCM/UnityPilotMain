//Author: Cotia Cosmin 
//Implementation: Move and jumping the player
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{   

    //Seting speed of the player and jumping distance 

    public float speed = 2.0f;
    public float jumpForce = 1;

    private Rigidbody2D _rigidbody;
   
    // Start is called before the first frame update 

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


  
    // Update is called once per frame
    private void Update()
    {
        MovePlayer();
        JumpPlayer();
        

    }


    // Using horizontal input to make player to move
    void MovePlayer()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;
    } 

    // Jumping method if player is on the ground 

    void JumpPlayer ()
    {

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }


    //using this method to collect coins


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
            
    }
}
