﻿using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {
	
	public string jumpButton = "Fire1";
	public float jumpPower = 10.0f;
	public Animator anim;
	public float minJumpDelay = 0.5f;
	public Transform groundCheck;
	private float jumpTime = 0.0f;
	public bool grounded = false;
	private bool jumped = false;
	private bool canJump = true;
	
	
	// Use this for initialization
	void Start () 
	{
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
		//cast a raycast to see if the player is touching anything on the "ground" layer.
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
		jumpTime -= Time.deltaTime;
		
		if(jumpTime < 0)
		{
			
			jumpTime = 0;
			
		}
		if(Input.GetButtonDown(jumpButton) && canJump == true)
		{
			
			canJump = false;
			jumped = true;
			grounded = false;
			anim.SetTrigger("Jump");
			rigidbody2D.AddForce(transform.up*jumpPower);
			jumpTime = minJumpDelay;
		}
		
		if(grounded && jumpTime <=0 && jumped)
		{
			canJump = true;
			jumped = false;
			anim.SetTrigger("Land");
		}
	}
	
}
