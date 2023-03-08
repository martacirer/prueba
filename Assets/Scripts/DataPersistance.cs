using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistance : MonoBehaviour
{
    public string TextUser;  

    public static DataPersistance PlayerStats;

    void Awake()
    {
        // Si la instancia no existe
        if (PlayerStats == null)
        {
            // Configuramos la instancia
            PlayerStats = this;
            // Nos aseguramos de que no sea destruida con el cambio de escena
            DontDestroyOnLoad(PlayerStats);
        }
        else
        {
            // Como ya existe una instancia, destruimos la copia
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       


        TextUser = PlayerPrefs.GetString("name");
        
    }

    // Update is called once per frame
    public void SaveStats()
    {
        PlayerPrefs.SetString("name", TextUser);
      
    }
}
