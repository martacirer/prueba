using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //Velocidad de translación
   public float speed = 100f;

    void Update()
    {
        //Mueve el GameObject hacia delante según la velocidad determinada
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
