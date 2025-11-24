using System;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movementInput;

    public float dashForce = 50f;

    public GameObject Bullet;

    private float rotation;
    private bool BulletShot;



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        gameObject.GetComponent<GameObject>();

        gameObject.GetComponent<Transform>();


    }

    void Update()
    {
        

        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");
        movementInput = movementInput.normalized;


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed * 2f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed / 2f;
        }


        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(movementInput * dashForce);    
            
        }
        
        
        
    }
    void FixedUpdate()
    {
        rb.linearVelocity = movementInput * moveSpeed * Time.deltaTime;
    }
        
    
}