using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private int puntos;
    //[SerializeField] private int puntosextra; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball")) 
        {
            puntosManager.addpoints(puntos);
        }
    }
}
