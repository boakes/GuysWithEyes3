using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour{

	public Camera playerCam;
	private Rigidbody rb; 
	public Vector3 forwardForce;

	public Vector3 backwardForce;
	private Vector3 jumpForce;

	private Vector3 initPos;

	public string playerNum;
	public float RT_P;
	public float LT_P;

 
	void Start(){
		//playerCam = Camera.main;
		forwardForce = playerCam.transform.forward * 100;
		backwardForce = forwardForce * -1;

		jumpForce = playerCam.transform.up * 1000;
		initPos = transform.position;
		rb = GetComponent<Rigidbody>();
		//mesh = GetComponent<MeshRenderer>();

	}

	void Update(){
		forwardForce = playerCam.transform.forward * 100;
		backwardForce = forwardForce * -1;
		
		
		RT_P = Input.GetAxis("RT_P"+playerNum);
		LT_P = Input.GetAxis("LT_P"+playerNum);
		//Debug.Log(horiz_player);

		if (RT_P > 0 || Input.GetKeyDown(KeyCode.W)){
			rb.AddForce(forwardForce);
		}
		if (LT_P > 0f){
			rb.velocity = Vector3.zero;
		}
		if(Input.GetButtonDown("A_P"+playerNum)){
			Debug.Log("A pressed");
			rb.AddForce(jumpForce);
		}
	}

}