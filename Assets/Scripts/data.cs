using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    // Instancia compartida
    public static DataPersistence sharedInstance;

    
    public string username;


    // Nos aseguramos de que la instancia sea ?nica
    private void Awake()
    {
        // Si la instancia no existe
        if (sharedInstance == null)
        {
            // Configuramos la instancia
            sharedInstance = this;
            // Nos aseguramos de que no sea destruida con el cambio de escena
            DontDestroyOnLoad(sharedInstance);
        }
        else
        {
            // Como ya existe una instancia, destruimos la copia
            Destroy(this);
        }
    }

    
}

