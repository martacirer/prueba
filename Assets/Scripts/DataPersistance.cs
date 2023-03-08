using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistance : MonoBehaviour
{
    public string TextUser;  

    public static DataPersistance PlayerStats;

    void Awake()
    {
       
        if (PlayerStats == null)
        {
            
            PlayerStats = this;
            
            DontDestroyOnLoad(PlayerStats);
        }
        else
        {
            
            Destroy(this);
        }
    }

   
    void Start()
    {
       


        TextUser = PlayerPrefs.GetString("name");
        
    }

    
    public void SaveStats()
    {
        PlayerPrefs.SetString("name", TextUser);
      
    }
}
