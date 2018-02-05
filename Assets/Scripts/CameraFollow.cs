using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


    private Transform target;
    private float distanceX;
    private float distanceY;

	// Use this for initialization
	void Start () {

        target = GameObject.Find("flash").transform.transform;
        
    }
    
    void Update()
    {

        distanceY = transform.position.y - (target.position.y + 15);
        transform.position = new Vector3(target.position.x + 40, transform.position.y - distanceY/1000, target.position.z + 7);

    }
}
