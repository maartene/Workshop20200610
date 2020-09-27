using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollisionEnter : MonoBehaviour
{
    public GameObject gib;
    //public GameObject destroyTarget;
    public bool armed = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag != "Player" || armed == false)
        {
            return;
        }

//        print("GameObject" + gameObject.name + " hit by " + collider.gameObject.name);
        if (gib != null)
        {
            Instantiate(gib, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
