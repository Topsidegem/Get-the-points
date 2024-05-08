using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resortera : MonoBehaviour
{
    public Transform resortera; 
    public GameObject ball; 
    public float fuerza = 10f; 
    public int maxBalls = 5; 

    [SerializeField] private bool lanzado = false;
    private int bolasLanzadas = 0;
    private GameObject[] objetosLanzados;

    void Start()
    {
        objetosLanzados = new GameObject[maxBalls];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !lanzado && bolasLanzadas < maxBalls)
        {
            LanzarObjeto();
        }
    }

    void LanzarObjeto()
    {
        GameObject objetoLanzado = Instantiate(ball, resortera.position, Quaternion.identity);
        objetosLanzados[bolasLanzadas] = objetoLanzado;
        bolasLanzadas++;

        Vector3 direccionLanzamiento = (Input.mousePosition - Camera.main.WorldToScreenPoint(resortera.position)).normalized;

        Rigidbody rb = objetoLanzado.GetComponent<Rigidbody>();
        rb.AddForce(direccionLanzamiento * fuerza, ForceMode.Impulse);

        lanzado = false;
    }
}
