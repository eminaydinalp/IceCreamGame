using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WhiteCube : MonoBehaviour
{
    
    Rigidbody whiteCube;

    void Start()
    {
        whiteCube = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "slindir" || other.gameObject.tag == "Player" || other.gameObject.tag == "Player2")
        {
            //Debug.Log("ss");
            //whiteCube.isKinematic = true;

            Destroy(whiteCube);
        }
       
    }

}
