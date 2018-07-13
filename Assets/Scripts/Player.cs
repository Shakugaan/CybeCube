using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private float MS = 6.0f;
    private float js = 20.0f;
    public Rigidbody rb;
    public bool isGrounded;
    public bool isonwall { get; set; }


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * MS;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Time.deltaTime * MS;
        }
        if (Input.GetKey(KeyCode.W)&& isGrounded)
        {
            rb.AddForce(Vector3.up * js);
            isGrounded = false;
        }
    }
    
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        { isGrounded = true; }
        if (other.gameObject.CompareTag("Wall"))
        { Destroy(this.gameObject); }
    }

}
