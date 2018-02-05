using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour{

	private Rigidbody rb; 
	public Vector3 forwardForce;

	public Vector3 backwardForce;
	private Vector3 jumpForce;

	private Vector3 initPos;

	public string playerNum;
	public float horiz_player;


	void Start(){
		forwardForce = new Vector3(-10f,0f,0f);
		backwardForce = new Vector3(10f,0f,0f);
		jumpForce = new Vector3(0f,10f,0f);
		initPos = transform.position;
		rb = GetComponent<Rigidbody>();
		//mesh = GetComponent<MeshRenderer>();

	}

	void Update(){
		horiz_player = Input.GetAxis("Horizontal_P"+playerNum);
		Debug.Log(horiz_player);

		if (horiz_player >= 1.0f){
			rb.AddForce(forwardForce);
		}
		if (horiz_player <= 0f){
			rb.AddForce(backwardForce);
		}
		if(Input.GetKey(KeyCode.Space)){
			rb.AddForce(jumpForce);
		}
	}

}