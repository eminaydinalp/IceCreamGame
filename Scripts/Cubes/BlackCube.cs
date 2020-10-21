using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCube : MonoBehaviour
{
    Rigidbody blackCube;

    void Start()
    {
        blackCube = GetComponent<Rigidbody>();
    }


    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "slindir" || other.gameObject.tag == "Player2" || other.gameObject.tag == "Player")
        {
            //Debug.Log("ss");
            //blackCube.isKinematic = true;
            Destroy(blackCube);

        }
    }
}
