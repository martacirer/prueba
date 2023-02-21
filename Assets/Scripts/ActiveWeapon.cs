using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{

    public TakeWeapon takeWeapons;
    public int numWeapon;
    // Start is called before the first frame update
    void Start()
    {
        takeWeapons = GameObject.FindGameObjectWithTag("Player").GetComponent<TakeWeapon>();
    }

   private void OnTriggerEnter(Collider other)
   {
          if(other.tag == "Player")
          {
            takeWeapons.ActivarArmas(numWeapon);
            Destroy(gameObject);
          }
   }
}
