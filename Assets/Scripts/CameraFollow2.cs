using UnityEngine;
using System.Collections;

public class CameraFollow2 : MonoBehaviour {

    public GameObject target;

    private float distanceX;
    private float distanceY;
    public string playerNum;
    public float LeftStick;

    // Use this for initialization
    void Start()
    {

        //target = GameObject.Find("flash").transform.transform;

    }

    void Update()
    {
        LeftStick = Input.GetAxis("Horizontal_P"+playerNum);
        //distanceY = transform.position.y - (target.position.y + 15);
        //transform.position = new Vector3(target.position.x + 40, (target.position.y + 15), target.position.z + 7);
       
       // 
        
        if(LeftStick > 0f){
            transform.RotateAround(target.transform.position,Vector3.up, -40 * Time.deltaTime);
        }else if (LeftStick < 0f){
            transform.RotateAround(target.transform.position,Vector3.up, 40 * Time.deltaTime);
        }
        
        transform.position = (transform.position - target.transform.position).normalized * 50 + target.transform.position;
        transform.LookAt(target.transform);
    }
}
