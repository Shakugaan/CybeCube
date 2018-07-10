using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private float MS = 15.0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * MS;
        }
        if (Input.GetKey(KeyCode.A))
        {
           

        }
    }
    private void Rotate(float angle)
    {

    }
}
