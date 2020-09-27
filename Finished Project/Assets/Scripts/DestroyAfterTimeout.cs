using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTimeout : MonoBehaviour
{
    public float delay = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
    }
}
