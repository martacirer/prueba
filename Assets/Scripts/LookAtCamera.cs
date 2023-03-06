using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField]private GameObject camera;
    
    void Start()
    {
        camera = GameObject.Find("Camera Player");

    }
    void Update()
    {
        transform.LookAt(camera.transform);
    }
}
