using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierCurveNew : MonoBehaviour
{
    [SerializeField] private Transform[] listaRutas;
    private int rutaId;
    private float tiempo;
    private Vector3 capsulaPos;
    private float velocidad;
    private bool permitirCoroutine;

    void Start()
    {
        rutaId = 0;
        tiempo = 0f;
        velocidad = 0.5f;
    }

    void Update()
    {
        StartCoroutine(SeguirRuta(rutaId));
    }

    private IEnumerator SeguirRuta(int numeroRuta)
    {
        Vector3 p0 = listaRutas[numeroRuta].GetChild(0).position;
        Vector3 p1 = listaRutas[numeroRuta].GetChild(1).position;
        Vector3 p2 = listaRutas[numeroRuta].GetChild(2).position;
        Vector3 p3 = listaRutas[numeroRuta].GetChild(3).position;

        while (tiempo < 1)
        {
            tiempo += velocidad * Time.deltaTime;

            capsulaPos = Mathf.Pow(1 - tiempo, 3) * p0 +
                3 * Mathf.Pow(1 - tiempo, 2) * tiempo * p1 +
                3 * (1 - tiempo) * Mathf.Pow(tiempo, 2) * p2 +
                Mathf.Pow(tiempo, 3) * p3;

            this.transform.position = capsulaPos;
            yield return new WaitForEndOfFrame();
        }
      

        tiempo = 0;
        rutaId++;
        

        if (rutaId > listaRutas.Length - 1)
        {
            rutaId = 0;

        }
            

    }
}
