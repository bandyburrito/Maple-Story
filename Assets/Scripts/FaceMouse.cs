using UnityEngine;

public class FaceMouse : MonoBehaviour
{
    private Camera mainCam;

    void Awake()
    {
        // Cache the camera so we don't find it every frame (optimization)
        mainCam = Camera.main;
    }

    void Update()
    {
        // 1. Get the mouse position in World Space (pixels -> coordinates)
        Vector3 mouseWorldPosition = mainCam.ScreenToWorldPoint(Input.mousePosition);

        // 2. Calculate the direction vector from the square to the mouse
        // (Target - Current = Direction)
        Vector3 direction = mouseWorldPosition - transform.position;

        // 3. Calculate the angle in degrees
        // Atan2 returns the angle in radians, so we convert it
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 4. Apply the rotation
        // Subtract 90 if your sprite is drawn facing "Up" instead of "Right"
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle)); 
    }
}