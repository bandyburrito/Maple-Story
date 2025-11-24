using Unity.VisualScripting;
using UnityEngine;

public class swapping : MonoBehaviour

{
    

    

    public enum WeaponType
    {
        Pistol,
        Shotgun,
        HealthPot
    }

    public void SetWeaponType(WeaponType weaponType){}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player
        }
    }
    
}
