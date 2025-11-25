using UnityEngine;

public class enemyshooting : MonoBehaviour
{

    public GameObject enemyBullet;
    public GameObject ShootingEnemies;
    private bool playerentered;
    public float enemyshootspeed = 20f;

    private Vector2 ShootingEnemiesPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerentered = true;
            Debug.Log("PlayerEntered the Second Room");
        }

        ShootingEnemiesPosition = new Vector2(ShootingEnemies.transform.position.x,ShootingEnemies.transform.position.y);

        

        gameObject.transform.position += transform.right * enemyshootspeed * Time.deltaTime;

        if (playerentered == true)
        {
            Instantiate(enemyBullet,ShootingEnemiesPosition,transform.rotation );
        }


        
    }

    
}
