using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{

    public float speed = 10f;

    private Rigidbody playerRigidbody;


    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//Se oculta el raton
    }



    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

       
        //Movimiento horizontal del player
        playerRigidbody.AddForce(playerRigidbody.gameObject.transform.right * speed * horizontalInput);
       
        //Movimiento vertical del player
        playerRigidbody.AddForce(playerRigidbody.gameObject.transform.forward * speed * verticalInput);
      
    }
}
