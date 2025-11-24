using UnityEngine;

public class enemyStats : MonoBehaviour
{

    private int maxHealth = 100;

    public int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            health -= 25;
            Debug.Log("Hit by Pistol & Max HP was" + maxHealth + " Current HP is " + health);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Shotgun"))
        {
            health -= 100;
            Debug.Log("Hit by Shotgun");
            Destroy(other.gameObject);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy Die");
        }

        
    }
    
        
    
}
