using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : TrigerAtackTop
{
    private void OnTriggerEnter(Collider other)
    {
        if(!other.gameObject.CompareTag("Death"))
        Instantiate(prefab,transform.position+ new Vector3(0,Y,0), Quaternion.identity);
    }


}
