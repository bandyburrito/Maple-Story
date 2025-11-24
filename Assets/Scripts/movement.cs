using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movementInput;
    public float dashForce = 50f;
    public GameObject PistolBullet;
    public GameObject ShotgunBullet;
    private bool pistolequipped;
    private bool shotgunequippped;
    public Image item1;
    public Image item2;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.GetComponent<GameObject>();
        gameObject.GetComponent<Transform>();
        pistolequipped = true; 
        Item2Color();
        
    }

    void Start()
    {
            
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

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pistolequipped = true;
            shotgunequippped = false;
            Item2Color();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            pistolequipped = false;
            shotgunequippped = true;
            Item1Color();
        }

    
        if (Input.GetButtonDown("Fire1") && pistolequipped == true)
        {
            Instantiate(PistolBullet, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("Fire1") && shotgunequippped == true)
        {
            Instantiate(ShotgunBullet, transform.position, transform.rotation);
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

    private void Item2Color()
    {
        Color tempColor1 = item1.color;
        tempColor1.a = 0.35f;
        item1.color = tempColor1;

        Color tempColor2 = item2.color;
        tempColor2.a = 1f;
        item2.color = tempColor2;
    }
    
    private void Item1Color()
    {
        Color tempColor2 = item2.color;
        tempColor2.a = 0.35f;
        item2.color = tempColor2;

        Color tempColor1 = item1.color;
        tempColor1.a = 1f;
        item1.color = tempColor1;
    }
        
    
}