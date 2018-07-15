using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    private float speed= 20f; //movement<>
    public float height = 2f; //jump^
    private float A = 0.0f; //Timer
    public Text Lives;
    public Rigidbody rb;

    void Start () {
        rb = GetComponent<Rigidbody>();
    }

	void Update ()
    {
        A += Time.deltaTime;
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        //Left & Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0.1f, 0, 0), speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(-0.1f, 0, 0), speed * Time.deltaTime);
        }
        //Up
        if (Input.GetKeyDown(KeyCode.W) && A>0.77)
        {
            A = 0;
            rb.AddForce(Vector3.up * speed * 2);
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Floor") && A>0.2)
        {
            A = 1;
        }      
        if (other.gameObject.CompareTag("Death"))
        {
            Lives.text = (int.Parse(Lives.text) + 1).ToString();
            transform.position = new Vector3(0.0f, 0.7f, 0.0f);
        }
    }  
}
