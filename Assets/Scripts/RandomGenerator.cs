using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour {

    public int randRacer;
    public int randCar;
    public int randAcc;
    
    public GameObject racer;
    public GameObject car;
    public GameObject acc;

    // Use this for initialization
    void Start () {
		
	}

    public void DeleteAll()
    {
        GameObject[] characters = GameObject.FindGameObjectsWithTag("character");
        foreach (GameObject o in characters)
        {
            Destroy(o);
        }
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            DeleteAll();

            randRacer = Random.Range(1, 10);
            randCar = Random.Range(1, 13);
            randAcc = Random.Range(1, 9);

            racer = Resources.Load("Prefabs/Racers/" + randRacer) as GameObject;
            car = Resources.Load("Prefabs/Cars/" + randCar) as GameObject;
            acc = Resources.Load("Prefabs/Accessories/" + randAcc) as GameObject;
            
            racer = Instantiate(racer) as GameObject;
            car = Instantiate(car) as GameObject;
            acc = Instantiate(acc) as GameObject;
        }
	}
}


