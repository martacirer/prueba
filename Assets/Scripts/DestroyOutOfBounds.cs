using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
   private float xmax = 1000f;
    private float ymax = 150f;
    private float zmax = 1000f;


    void Update()
    {
        //destroy bullet when is out 
        if (transform.position.x > xmax)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -xmax)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > ymax)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -ymax)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > zmax)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -zmax)
        {
            Destroy(gameObject);
        }
    }
}
