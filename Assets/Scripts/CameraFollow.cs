using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject target;
	public Vector3 offsetFromTarget;
	public bool followTarget = true;

	// Use this for initialization
	void Start () {
		offsetFromTarget = target.transform.position - transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
		if(followTarget){
			transform.position = target.transform.position - offsetFromTarget;
		}
	}
}
