using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicMovement : MonoBehaviour
{
    public float speed = 20;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    Rigidbody rb;
    // Start is called before the first frame update
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += (Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.position += (Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.position += (Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.position += (Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
