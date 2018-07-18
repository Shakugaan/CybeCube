using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerAtackTop : MonoBehaviour
{
    public float X = new float();
    public float Y = new float();
    public float Z = new float();
    public Transform prefab; 
    private void OnTriggerEnter(Collider other)
    {
            Instantiate(prefab, new Vector3(X, Y, Z), Quaternion.identity);    
    }
}
