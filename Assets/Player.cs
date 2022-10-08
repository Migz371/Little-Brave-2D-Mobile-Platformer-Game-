using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Basic Player Script//
//controls: 
//A, D, Left, Right to move
//Left Alt to attack
//Space to jump
//Z is to see dead animation

public class Player : MonoBehaviour {

	//variable for how fast player runs//
	private float speed = 5f;

	private bool facingRight = true;
	private Animator anim;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;

	Rigidbody2D playerRigid;

	//variable for how high player jumps//
	[SerializeField]
	private float jumpForce;
	BoxCollider2D playerCollider;

	public Rigidbody2D rb { get; set; }

	bool dead = false;
	bool attack = false;

	public static bool isJumping=false;

	//restart
	public static bool nalaglag = false;

	void Start () {
		GetComponent<Rigidbody2D> ().freezeRotation = true;
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponentInChildren<Animator> ();
		playerRigid = GetComponent<Rigidbody2D>();
		playerCollider = GetComponent<BoxCollider2D>();
	}

	void Update()
	{
		HandleInput ();


		if(playerRigid.position.y <= -60)
        {
			nalaglag = true;
        }
	}

	//movement//
	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		float horizontal = Input.GetAxis("Horizontal");
		if (!dead && !attack)
		{
			anim.SetFloat ("vSpeed", rb.velocity.y);
			anim.SetFloat ("Speed", Mathf.Abs (horizontal));
			rb.velocity = new Vector2 (horizontal * speed, rb.velocity.y);
		}
		if (horizontal > 0 && !facingRight && !dead && !attack) {
			Flip (horizontal);
		}

		else if (horizontal < 0 && facingRight && !dead && !attack){
			Flip (horizontal);
		}
	}

	//attacking and jumping//
	private void HandleInput()
	{
		if (Input.GetKeyDown (KeyCode.L) && !dead) 
		{
			attack = true;
			anim.SetBool ("Attack", true);
			anim.SetFloat ("Speed", 0);

		}
		if (Input.GetKeyUp(KeyCode.L))
			{
			attack = false;
			anim.SetBool ("Attack", false);
			}

		if (grounded && Input.GetKeyDown(KeyCode.Space) && !dead )
		{
			anim.SetBool ("Ground", false);
			rb.AddForce (new Vector2 (0,jumpForce));
			
		}
        if (grounded)
        {
			isJumping = false;
        }
        if (!grounded)
        {
			isJumping = true;
		}

		//dead animation for testing//
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			if (!dead) {
				anim.SetBool ("Dead", true);
				anim.SetFloat ("Speed", 0);
				dead = true;
			} else {
					anim.SetBool ("Dead", false);
					dead = false;
				}
		}
	}
		
	private void Flip (float horizontal)
	{
			facingRight = !facingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
	}


}
