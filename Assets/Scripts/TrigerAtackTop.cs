using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerAtackTop : MonoBehaviour {
    public float X = new float();
    public float Y = new float();
    public float Z = new float();
    public Transform prefab;
    // Use this for initialization
    void Start ()
    {

         
}
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        
            Instantiate(prefab, new Vector3(X, Y, Z), Quaternion.identity);
       
    }

}
