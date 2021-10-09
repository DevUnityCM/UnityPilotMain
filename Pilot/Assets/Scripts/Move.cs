//Author: Cotia Cosmin 
//Release: Sprint1 
//Implementation: Move and jumping attack and sit the player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Move : MonoBehaviour
{

    //Seting speed of the player and jumping distance 

    public float speed = 2.0f;
    public float jumpForce = 1;
    public int scoreTotal;

    private Rigidbody2D _rigidbody;
    public ScoreManager instanceS;
    public ScoreManager levelLoader;
    public Animator anim;
    



    // Update Animator when game is Awaked 
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    private void Update()
    {
        MovePlayer();
        JumpPlayer();
        AttackPlayer();
        SitPlayer();
        MenuGame();

    }


    // Using horizontal input to make player to move
    void MovePlayer()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if (movement != 0)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }


    }

    // Jumping method if player is on the ground 

    void JumpPlayer()
    { 

        // If don`t use animation to jump please use this code snipped 
        /*
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("Jump", true);
        } else
        {
            anim.SetBool("Jump", false);

        } */

        Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            anim.SetBool("Jump", true);
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
    }


    // This function is used to attack enemies 
    void AttackPlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Attack", true);

        } else
        {
            anim.SetBool("Attack", false);
        }


    }


    // Use to make player sit down for a second 
    // csm: This should be improved and implemented as a courutine with the next release 
    void SitPlayer()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {

            anim.SetBool("Sit", true);

        } else
        {
            anim.SetBool("Sit", false);


        }
         
    }
     

// This function will exit from the game if player hits escape button 
   void MenuGame ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    // This function is used to collect points and distroy coins
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }

        
        
    }

   

}
