using System;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public float bulletspeed = 20f;
    public Rigidbody2D rb;
    public GameObject Pistol;
    public GameObject Shotgun;

    
   
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            

            
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {

            

        }
        
        
    }

    void FixedUpdate()
    {
        transform.position += transform.right * bulletspeed * Time.deltaTime;
    }

    
}
