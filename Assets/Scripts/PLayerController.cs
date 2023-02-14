using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public float speed = 10f;
    
   
    private Rigidbody playerRigidbody;

    public float forceJump;
    //float velocity;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//Se oculta el raton

        Physics.gravity *= 1;
    }

    void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");

         transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
         transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

         if(Input.GetKeyDown(KeyCode.Space))
         {
             //velocity = forceJump;
             //transform.Translate(new Vector3(0, gravity * forceJump, 0) * Time.deltaTime);
             playerRigidbody.AddForce(Vector3.up * forceJump, ForceMode.Impulse);
             
         }
        
         
         if(Input.GetKeyDown(KeyCode.LeftShift))
         {
            speed *= 2;
         }

           
         if(Input.GetKeyUp(KeyCode.LeftShift))
         {
            speed /= 2;
         }

          
    }

 
    
    /*
    void FixedUpdate()
    {
       

       
        //Movimiento horizontal del player
        playerRigidbody.AddForce(playerRigidbody.gameObject.transform.right * speed * horizontalInput);
       
        //Movimiento vertical del player
        playerRigidbody.AddForce(playerRigidbody.gameObject.transform.forward * speed * verticalInput);
      
    }*/
}
