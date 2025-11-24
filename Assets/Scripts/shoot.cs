using UnityEngine;

public class shoot : MonoBehaviour
{

    public float bulletspeed = 50f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.position += transform.right * bulletspeed * Time.deltaTime;
    }
    
}
