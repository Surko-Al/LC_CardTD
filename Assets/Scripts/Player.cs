using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private Rigidbody rb;
    public bool isJump;
    public float horizontalInput;
    public float verticalInput;
    

    private Vector3 movement;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(isJump)
        {
            Debug.Log(isJump);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        movement = new Vector3(horizontalInput, 0f, verticalInput)*speed*Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }
}
