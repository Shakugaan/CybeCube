using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour {


    public float speed = 20.0f;
    // Use this for initialization
    void Start () {

    }   
	
	// Update is called once per frame
	void Update () {
        rotator(this.speed);
       
	}
    private void rotator(float x)
    {
        transform.Rotate(Vector3.up,Time.deltaTime * x);
    }
}
