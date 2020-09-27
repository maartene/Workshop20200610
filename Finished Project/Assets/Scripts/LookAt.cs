using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called once per frame, after all other scripts/physics/actions/calculations finished processing.
    void LateUpdate()
    {
        Quaternion lookRotation = Quaternion.LookRotation(
            target.position - transform.position, Vector3.forward);
        transform.rotation = lookRotation;
    }
}
