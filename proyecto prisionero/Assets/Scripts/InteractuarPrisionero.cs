using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarPrisionero : MonoBehaviour
{
   public Animator animadorPersonaje;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animadorPersonaje.SetBool("Caminando", false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animadorPersonaje.SetBool("Caminando", true);
        }
    }
}
