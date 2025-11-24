using System;
using UnityEngine;
using UnityEngine.UI;

public class changeguns : MonoBehaviour
{
    public GameObject Pistol;
    public GameObject Shotgun;

    private bool getgun1;
    private bool getgun2;

    private bool removedgun1;
    private bool removedgun2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        getgun1 = gameObject.GetComponent<GameObject>();
        getgun2 = gameObject.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {

            getgun1 = true;
            removedgun2 = true;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {

            removedgun1 = true;
            getgun2 = true;

        }
        
    }
}
