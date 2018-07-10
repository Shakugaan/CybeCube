using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public float distance = 3.0f;
    public float height = 3.0f;
    public Transform Target;
    
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Target.transform.position + new Vector3(0.0f,height,-distance);
	}
}
