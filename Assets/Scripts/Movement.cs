using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour{

	private Rigidbody rb; 
	private Vector3 forwardForce;
	private Vector3 jumpForce;

	private Vector3 initPos;

	void Start(){
		forwardForce = new Vector3(-10f,0f,0f);
		jumpForce = new Vector3(0f,10f,0f);
		initPos = transform.position;
		rb = GetComponent<Rigidbody>();
		//mesh = GetComponent<MeshRenderer>();

	}

	void Update(){
		if (Input.GetKey(KeyCode.A)){
			rb.AddForce(forwardForce);
		}
		if(Input.GetKey(KeyCode.Space)){
			rb.AddForce(jumpForce);
		}
	}

}