using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour {

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Dest"))
        {
            Destroy(collision.gameObject);
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Dest"))
        {
            Destroy(other.gameObject);
        }
    }
}
