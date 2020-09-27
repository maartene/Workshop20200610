using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowUp : MonoBehaviour
{
    public float force = 1000f;
    public float delay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.AddExplosionForce(force, transform.position, 4);            
        }
        Invoke("Fall", delay);
    }

    void Fall()
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();
        foreach (Collider col in colliders) 
        {
            col.isTrigger = true;
        }
    }
}
