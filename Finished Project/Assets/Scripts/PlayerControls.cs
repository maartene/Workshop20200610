using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float force = 100f;
    public float jumpForce = 1000f;

    Rigidbody rb;

    bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalForce = Input.GetAxis("Horizontal") * force * Time.deltaTime;
        float verticalForce = Input.GetAxis("Vertical") * force * Time.deltaTime;
        Vector3 forceToAdd = new Vector3(horizontalForce, 0, verticalForce);
        rb.AddForce(forceToAdd);

        if (canJump && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        canJump = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }
}
