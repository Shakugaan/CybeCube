using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public float distance = 3.0f;
    public float height = 3.0f;
    public Transform Target;
    private int x = 0;
    
    
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        try
        {
            transform.position = Target.transform.position + new Vector3(0.0f, height, -distance);
        }
        catch
        {
            x++;
            if (x < 1)
            { transform.position += new Vector3(0.0f, height, -distance / 1.001f); }
            
        }
	}
}
