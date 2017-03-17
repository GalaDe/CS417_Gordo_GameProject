using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    //New
    public Text ScoreText;
    public Rigidbody2D rigidBody;
    public float walkSpeed = 7f;
    public float runSpeed = 10f;
    public float jump;
    public float moveVelocity;
    Animator anim;
    public bool facingRight = true;
    public bool isActive = false;
    public int score = 0;
    public bool collision = false;
    public GenerateCoins genCoins;


    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

	void Update () {

        //Left Right Movement + Animation controls
        moveVelocity = Input.GetAxis("Horizontal") * walkSpeed ;
        //rigidBody.velocity = new Vector2(moveVelocity * walkSpeed, rigidBody.velocity.y);

            if (facingRight && isActive)
                //rigidBody.AddForce(new Vector2(500, 0) * Time.fixedDeltaTime);
                rigidBody.MovePosition(rigidBody.position + new Vector2(10, 0) * Time.fixedDeltaTime);
            //transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
            else
                rigidBody.MovePosition(rigidBody.position + new Vector2(-10, 0) * Time.fixedDeltaTime);

        //rigidBody.AddForce(new Vector2(500, 0) * Time.fixedDeltaTime);
        // transform.Translate(Vector3.right * walkSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            anim.SetBool("Walk_01", true);
        else if (Input.GetKey(KeyCode.LeftArrow))
            anim.SetBool("Walk_01", true);
        else if (Input.GetKeyDown(KeyCode.Space))
            anim.SetBool("Run_02", true);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            anim.SetBool("Jump_01", true);
        else
            anim.SetBool("Idle_01", false);

        //Flipping right and left
        if (moveVelocity > 0 && facingRight)
            Flip();
        else if (moveVelocity < 0 && !facingRight)
            Flip();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Pick Up"))
        {
            score += 10;
            if (score <= 100)
            {
                other.gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("Stop");
                anim.SetBool("Walk_01", true);
                ScoreText.text = "Game Over! You Passed Level 1!";
         
                //genCoins.StopCoroutine(genCoins.CoinSpawn());
                Time.timeScale = 1.0F;
            }
        }
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag.Equals("Ops"))
        {
            Destroy(other.gameObject);

        }
           
    }


    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
		
